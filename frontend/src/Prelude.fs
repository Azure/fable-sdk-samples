[<AutoOpen>]
module Prelude

module Routes =
    open Elmish.UrlParser

    type Route = 
      | Home
      | Guest

    let guid state =
        custom "guid" (System.Guid.TryParse >> function true, value -> Ok value | _ -> Error "Can't parse Guid" ) state

    let route : Parser<Route->Route,_> =
        oneOf
            [ map Home (s "start")
              map Guest (s "guest")]

    let toAddress route =
        match route with
        | Home -> "/"    
        | Guest -> "/guest"
