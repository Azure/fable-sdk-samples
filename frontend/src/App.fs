module App.State

open Browser
open Elmish
open Elmish.Navigation
open Types
    
let init (account, cmd: Cmd) route : Model*Cmd<Msg> =
    match route, account with
    | Some Routes.Home, Some r ->
        Unauthenticated, Cmd.ofMsg (LoggedIn r)
    | _ -> Unauthenticated, cmd.login LoggedIn Failed


let update (cmd: Cmd) (msg: Msg) (model: Model) =
    match model, msg with
    | _, LogIn ->
        Unauthenticated, cmd.login LoggedIn Failed
    | _, LoggedIn r ->
        Authenticated { route = Routes.Home
                        user = None },
        Cmd.batch [ cmd.getSignedInUser Loaded Failed
                    match r.state with Some state when state <> window.location.hash -> Navigation.newUrl state | _ -> () ]
    | Authenticated state, Loaded r ->
        Authenticated { state with user = Some (upcast r) }, Cmd.none
    | _, Failed e ->
        console.error e
        model, Cmd.none
    | _, LogOut ->
        Unauthenticated, Cmd.batch [ cmd.logout Failed
                                     Navigation.newUrl (Routes.toAddress Routes.Guest)]
    | _ -> model, Cmd.none                   


let urlUpdate (result: Option<Routes.Route>) model =
    match result, model with
    | Some page, Authenticated state ->
        Authenticated {state with route = page}, []
    | _ ->
        model, Navigation.modifyUrl (Routes.toAddress Routes.Home) // no matching route - go home

open Elmish.React
open Elmish.HMR

// App
promise {
    let! account, cmd = Cmd.ofConfig "/options.json"
    Program.mkProgram (init (account, cmd)) (update cmd) View.root
    |> Program.toNavigable (UrlParser.parsePath Routes.route) urlUpdate
    |> Program.withReactSynchronous "elmish-app"
    |> Program.withConsoleTrace
    |> Program.run
} |> ignore
