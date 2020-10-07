namespace App

open Fable.Core.JS
open Elmish
open Browser
open Fable.Core.JsInterop
open Azure.Sdk
open Types

type Msal =
    abstract login : onSuccess:(Msal.AuthenticationResult->'msg) -> onFailure:(exn->'msg) -> Cmd<'msg>
    abstract logout : onFailure:(exn->'msg) -> Cmd<'msg>

type Graph =
    abstract getSignedInUser : onSuccess: (Graph.SignedInUserGetResponse->'msg) -> onFailure:(exn->'msg) -> Cmd<'msg>

type Cmd =
    inherit Msal
    inherit Graph

module Msal =
    let login (client:Msal.PublicClientApplication) (authParams:Msal.RedirectRequest) (success:Msal.AuthenticationResult->'msg) (failure:exn -> 'msg) =
        let bind dispatch =
            let onResponse (r:Msal.AuthenticationResult option) =
                match r with 
                | Some r -> success r |> dispatch
                | _ -> ()
            let p = promise {
                try
                    do! client.handleRedirectPromise().``then`` onResponse 
                    // for SSO try client.ssoSilent
                    let! r = client.acquireTokenSilent !!{| account = client.getAllAccounts() |> Seq.tryHead
                                                            scopes = authParams.scopes |}
                    onResponse (Some r)
                with _ ->
                    authParams.redirectStartPage <- !!window.location.hash
                    do! client.loginRedirect authParams
            }
            p.catch(unbox >> failure >> dispatch) |> ignore
        [bind]

    let logout (client:Msal.PublicClientApplication) (failure:exn -> 'msg)=
        Cmd.OfPromise.attempt client.logout () failure


module Cmd =
    type Options =
        { authParams: Msal.RedirectRequest
          msal: Msal.Configuration
          subscriptionId: string
          tenantId: string }

    let ofConfig (address: string) =
        promise {
            let! response = Fetch.fetch address []
            let! (options:Options) = !!response.json()
            console.log("Configuration:", options)
            let msal = Msal.exports.PublicClientApplication.Create options.msal
            let account = None // for SSO this could be loaded
            let credentials = 
                { new MsRest.ServiceClientCredentials with
                    member __.signRequest (r: MsRest.WebResourceLike) =
                        promise {
                            let! token = msal.acquireTokenSilent !!{| account = msal.getAllAccounts() |> Seq.tryHead
                                                                      scopes = options.authParams.scopes |}
                            r.headers.set("Authorization", !!(sprintf "Bearer %s" token.accessToken))
                            return r
                        }
                }
            let graph = Graph.exports.GraphRbacManagementClient.Create (credentials, options.tenantId)

            return account, 
                { new Cmd with
                    member __.login success failure = Msal.login msal options.authParams success failure
                    member __.logout fail = Msal.logout msal fail
                    member __.getSignedInUser success failure = Cmd.OfPromise.either (fun _ -> graph.signedInUser.get()) () success failure
                }
        }

