module App.Types

type AuthenticatedState = 
    { route: Routes.Route
      user: Azure.Sdk.Graph.User option }

type Model =
  | Authenticated of AuthenticatedState
  | Unauthenticated of Routes.Route

type Msg = 
  | Failed of exn
  | LoggedIn of Azure.Sdk.Msal.AuthenticationResult
  | LogIn
  | LogOut
  | Loaded of Azure.Sdk.Graph.SignedInUserGetResponse
  | GoTo of Routes.Route
