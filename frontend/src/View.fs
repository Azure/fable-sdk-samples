module App.View

open Fable.React
open Fable.React.Props
open Types
open Routes
open Fulma
open Fable.FontAwesome

module NavBar =
    let view dispatch =
        Navbar.navbar [ ]
            [ Navbar.End.div [] [ Navbar.Item.div [] [ Button.button [ Button.OnClick (fun _ -> dispatch LogOut) ] [ str "Logout" ] ] ] ]

let root (model: Model) dispatch =
    let onClick msg = OnClick <| fun _ -> dispatch msg

    match model with
    | Authenticated state ->
        Hero.hero [ Hero.IsFullHeight ] [
            Hero.head [] [ NavBar.view dispatch ]
            Hero.body [] [
                Container.container [] [
                    Columns.columns [ Columns.CustomClass "has-text-centered" ] [
                        Column.column [ Column.Width(Screen.All, Column.IsOneThird)
                                        Column.Offset(Screen.All, Column.IsOneThird) ]
                                      [ match state.user with
                                        | Some user -> Content.content [] [ str (sprintf "Hello, %A!" user.displayName) ]
                                        | _ -> Content.content [] [ str "Loading user info..." ] 
                                      ]
            ] ] ] ]

    | Unauthenticated -> div [] []
