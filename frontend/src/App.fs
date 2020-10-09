module App.State

open Browser
open Elmish
open Elmish.Navigation
open Types
    
let init (account, cmd: Cmd) route : Model*Cmd<Msg> =
    match route, account with
    | Some r, Some a ->
        Unauthenticated r, Cmd.ofMsg (LoggedIn a)
    | Some r, None ->
        Unauthenticated r, cmd.login LoggedIn Failed
    | _ -> Unauthenticated Routes.Home, cmd.login LoggedIn Failed


let update (cmd: Cmd) (msg: Msg) (model: Model) =
    match model, msg with
    | Unauthenticated route, LogIn ->
        Unauthenticated route, cmd.login LoggedIn Failed
    | Authenticated state, LogIn ->
        Unauthenticated state.route, cmd.login LoggedIn Failed
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
        Unauthenticated Routes.Guest, 
        Cmd.batch [ cmd.logout Failed
                    Navigation.newUrl (Routes.toAddress Routes.Guest)]
    | _ -> model, Cmd.none                   


let urlUpdate (result: Option<Routes.Route>) model =
    match result, model with
    | Some page, Authenticated state ->
        Authenticated {state with route = page}, []
    | Some route, Unauthenticated _ ->
        Unauthenticated route, []
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
