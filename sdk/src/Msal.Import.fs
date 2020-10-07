// ts2fable 0.7.1
module rec Azure.Sdk.Msal
open System
open Fable.Core
open Fable.Core.JS
open System.Collections.Generic

type Array<'T> = 'T array
type Record<'T,'K> = IDictionary<'T,'K>
type Error = System.Exception

let [<Import("*","@azure/msal-browser")>] exports: IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract AccessTokenEntity: AccessTokenEntityStatic
    abstract AccountEntity: AccountEntityStatic
    abstract AppMetadataEntity: AppMetadataEntityStatic
    abstract AuthError: AuthErrorStatic
    abstract Authority: AuthorityStatic
    abstract AuthorizationCodeClient: AuthorizationCodeClientStatic
    abstract AuthToken: AuthTokenStatic
    abstract BaseClient: BaseClientStatic
    abstract BrowserAuthError: BrowserAuthErrorStatic
    abstract BrowserConfigurationAuthError: BrowserConfigurationAuthErrorStatic
    abstract BrowserStorage: BrowserStorageStatic
    abstract CacheManager: CacheManagerStatic
    abstract CacheRecord: CacheRecordStatic
    abstract ClientApplication: ClientApplicationStatic
    abstract CredentialEntity: CredentialEntityStatic
    abstract CryptoOps: CryptoOpsStatic
    abstract IdTokenEntity: IdTokenEntityStatic
    abstract InteractionRequiredAuthError: InteractionRequiredAuthErrorStatic
    abstract Logger: LoggerStatic
    abstract NetworkManager: NetworkManagerStatic
    abstract PublicClientApplication: PublicClientApplicationStatic
    abstract RefreshTokenClient: RefreshTokenClientStatic
    abstract RefreshTokenEntity: RefreshTokenEntityStatic
    abstract ScopeSet: ScopeSetStatic
    abstract ServerError: ServerErrorStatic
    abstract ServerTelemetryManager: ServerTelemetryManagerStatic
    abstract SilentFlowClient: SilentFlowClientStatic

type AccessTokenCache =
    Record<string, AccessTokenEntity>

/// ACCESS_TOKEN Credential Type
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-accesstoken-clientId-contoso.com-user.read
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, usually only used for refresh tokens
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
///       cachedAt: Absolute device time when entry was created in the cache.
///       expiresOn: Token expiry time, calculated based on current UTC time in seconds. Represented as a string.
///       extendedExpiresOn: Additional extended expiry time until when token is valid in case of server-side outage. Represented as string in UTC seconds.
///       keyId: used for POP and SSH tokenTypes
///       tokenType: Type of the token issued. Usually "Bearer"
/// }
type [<AllowNullLiteral>] AccessTokenEntity =
    inherit CredentialEntity
    abstract realm: string with get, set
    abstract target: string with get, set
    abstract cachedAt: string with get, set
    abstract expiresOn: string with get, set
    abstract extendedExpiresOn: string option with get, set
    abstract refreshOn: string option with get, set
    abstract keyId: string option with get, set
    abstract tokenType: string option with get, set

/// ACCESS_TOKEN Credential Type
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-accesstoken-clientId-contoso.com-user.read
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, usually only used for refresh tokens
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
///       cachedAt: Absolute device time when entry was created in the cache.
///       expiresOn: Token expiry time, calculated based on current UTC time in seconds. Represented as a string.
///       extendedExpiresOn: Additional extended expiry time until when token is valid in case of server-side outage. Represented as string in UTC seconds.
///       keyId: used for POP and SSH tokenTypes
///       tokenType: Type of the token issued. Usually "Bearer"
/// }
type [<AllowNullLiteral>] AccessTokenEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AccessTokenEntity
    /// Create AccessTokenEntity
    abstract createAccessTokenEntity: homeAccountId: string * environment: string * accessToken: string * clientId: string * tenantId: string * scopes: string * expiresOn: float * extExpiresOn: float * ?tokenType: string * ?oboAssertion: string -> AccessTokenEntity
    /// Validates an entity: checks for all expected params
    abstract isAccessTokenEntity: entity: obj -> bool

type AccountCache =
    Record<string, AccountEntity>

/// Type that defines required and optional parameters for an Account field (based on universal cache schema implemented by all MSALs).
/// 
/// Key : Value Schema
/// 
/// Key: <home_account_id>-<environment>-<realm*>
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       realm: Full tenant or organizational identifier that the account belongs to
///       localAccountId: Original tenant-specific accountID, usually used for legacy cases
///       username: primary username that represents the user, usually corresponds to preferred_username in the v2 endpt
///       authorityType: Accounts authority type as a string
///       name: Full name for the account, including given name and family name,
///       clientInfo: Full base64 encoded client info received from ESTS
///       lastModificationTime: last time this entity was modified in the cache
///       lastModificationApp:
///       oboAssertion: access token passed in as part of OBO request
/// }
type [<AllowNullLiteral>] AccountEntity =
    abstract homeAccountId: string with get, set
    abstract environment: string with get, set
    abstract realm: string with get, set
    abstract localAccountId: string with get, set
    abstract username: string with get, set
    abstract authorityType: string with get, set
    abstract name: string option with get, set
    abstract clientInfo: string option with get, set
    abstract lastModificationTime: string option with get, set
    abstract lastModificationApp: string option with get, set
    abstract oboAssertion: string option with get, set
    /// Generate Account Id key component as per the schema: <home_account_id>-<environment>
    abstract generateAccountId: unit -> string
    /// Generate Account Cache Key as per the schema: <home_account_id>-<environment>-<realm*>
    abstract generateAccountKey: unit -> string
    /// returns the type of the cache (in this case account)
    abstract generateType: unit -> float
    /// Returns the AccountInfo interface for this account.
    abstract getAccountInfo: unit -> AccountInfo

/// Type that defines required and optional parameters for an Account field (based on universal cache schema implemented by all MSALs).
/// 
/// Key : Value Schema
/// 
/// Key: <home_account_id>-<environment>-<realm*>
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       realm: Full tenant or organizational identifier that the account belongs to
///       localAccountId: Original tenant-specific accountID, usually used for legacy cases
///       username: primary username that represents the user, usually corresponds to preferred_username in the v2 endpt
///       authorityType: Accounts authority type as a string
///       name: Full name for the account, including given name and family name,
///       clientInfo: Full base64 encoded client info received from ESTS
///       lastModificationTime: last time this entity was modified in the cache
///       lastModificationApp:
///       oboAssertion: access token passed in as part of OBO request
/// }
type [<AllowNullLiteral>] AccountEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AccountEntity
    /// Generates account key from interface
    abstract generateAccountCacheKey: accountInterface: AccountInfo -> string
    /// Build Account cache from IdToken, clientInfo and authority/policy
    abstract createAccount: clientInfo: string * authority: Authority * idToken: AuthToken * crypto: ICrypto * ?oboAssertion: string -> AccountEntity
    /// Build ADFS account type
    abstract createADFSAccount: authority: Authority * idToken: AuthToken * ?oboAssertion: string -> AccountEntity
    /// Validates an entity: checks for all expected params
    abstract isAccountEntity: entity: obj -> bool

type [<AllowNullLiteral>] AccountFilter =
    abstract homeAccountId: string option with get, set
    abstract environment: string option with get, set
    abstract realm: string option with get, set

type [<AllowNullLiteral>] AccountInfo =
    abstract homeAccountId: string with get, set
    abstract environment: string with get, set
    abstract tenantId: string with get, set
    abstract username: string with get, set
    abstract name: string option with get, set

/// APP_METADATA Cache
/// 
/// Key:Value Schema:
/// 
/// Key: appmetadata-<environment>-<client_id>
/// 
/// Value:
/// {
///       clientId: client ID of the application
///       environment: entity that issued the token, represented as a full host
///       familyId: Family ID identifier, '1' represents Microsoft Family
/// }
type [<AllowNullLiteral>] AppMetadataEntity =
    abstract clientId: string with get, set
    abstract environment: string with get, set
    abstract familyId: string option with get, set
    /// Generate AppMetadata Cache Key as per the schema: appmetadata-<environment>-<client_id>
    abstract generateAppMetadataKey: unit -> string

/// APP_METADATA Cache
/// 
/// Key:Value Schema:
/// 
/// Key: appmetadata-<environment>-<client_id>
/// 
/// Value:
/// {
///       clientId: client ID of the application
///       environment: entity that issued the token, represented as a full host
///       familyId: Family ID identifier, '1' represents Microsoft Family
/// }
type [<AllowNullLiteral>] AppMetadataEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AppMetadataEntity
    /// Generate AppMetadata Cache Key
    abstract generateAppMetadataCacheKey: environment: string * clientId: string -> string
    /// Creates AppMetadataEntity
    abstract createAppMetadataEntity: clientId: string * environment: string * ?familyId: string -> AppMetadataEntity
    /// Validates an entity: checks for all expected params
    abstract isAppMetadataEntity: key: string * entity: obj -> bool

type [<AllowNullLiteral>] AuthenticationResult =
    abstract uniqueId: string with get, set
    abstract tenantId: string with get, set
    abstract scopes: Array<string> with get, set
    abstract account: AccountInfo with get, set
    abstract idToken: string with get, set
    abstract idTokenClaims: obj with get, set
    abstract accessToken: string with get, set
    abstract fromCache: bool with get, set
    abstract expiresOn: DateTime with get, set
    abstract tokenType: string with get, set
    abstract extExpiresOn: DateTime option with get, set
    abstract state: string option with get, set
    abstract familyId: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AuthenticationScheme =
    | [<CompiledName "pop">] POP
    | [<CompiledName "Bearer">] BEARER

/// General error class thrown by the MSAL.js library.
type [<AllowNullLiteral;AbstractClass>] AuthError =
    inherit Error
    abstract errorCode: string with get, set
    abstract errorMessage: string with get, set
    abstract suberror: string with get, set

/// General error class thrown by the MSAL.js library.
type [<AllowNullLiteral>] AuthErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string * ?suberror: string -> AuthError
    /// Creates an error that is thrown when something unexpected happens in the library.
    abstract createUnexpectedError: errDesc: string -> AuthError

type [<AllowNullLiteral>] AuthOptions =
    abstract clientId: string with get, set
    abstract authority: Authority option with get, set
    abstract knownAuthorities: Array<string> option with get, set
    abstract cloudDiscoveryMetadata: string option with get, set
    abstract clientCapabilities: Array<string> option with get, set

/// The authority class validates the authority URIs used by the user, and retrieves the OpenID Configuration Data from the
/// endpoint. It will store the pertinent config data in this object for use during token calls.
type [<AllowNullLiteral>] Authority =
    abstract networkInterface: INetworkModule with get, set
    /// Boolean that returns whethr or not tenant discovery has been completed.
    abstract discoveryComplete: unit -> bool
    /// Perform endpoint discovery to discover the /authorize, /token and logout endpoints.
    abstract resolveEndpointsAsync: unit -> Promise<unit>

/// The authority class validates the authority URIs used by the user, and retrieves the OpenID Configuration Data from the
/// endpoint. It will store the pertinent config data in this object for use during token calls.
type [<AllowNullLiteral>] AuthorityStatic =
    [<Emit "new $0($1...)">] abstract Create: authority: string * networkInterface: INetworkModule -> Authority
    /// helper function to generate environment from authority object
    abstract generateEnvironmentFromAuthority: authority: Authority -> string

type [<RequireQualifiedAccess>] AuthorityType =
    | Default = 0
    | Adfs = 1

/// Oauth2.0 Authorization Code client
type [<AllowNullLiteral>] AuthorizationCodeClient =
    inherit BaseClient
    /// Creates the URL of the authorization request letting the user input credentials and consent to the
    /// application. The URL target the /authorize endpoint of the authority configured in the
    /// application object.
    /// 
    /// Once the user inputs their credentials and consents, the authority will send a response to the redirect URI
    /// sent in the request and should contain an authorization code, which can then be used to acquire tokens via
    /// acquireToken(AuthorizationCodeRequest)
    abstract getAuthCodeUrl: request: AuthorizationUrlRequest -> Promise<string>
    /// API to acquire a token in exchange of 'authorization_code` acquired by the user in the first leg of the
    /// authorization_code_grant
    abstract acquireToken: request: AuthorizationCodeRequest * ?cachedNonce: string * ?cachedState: string -> Promise<AuthenticationResult>
    /// Handles the hash fragment response from public client code request. Returns a code response used by
    /// the client to exchange for a token in acquireToken.
    abstract handleFragmentResponse: hashFragment: string * cachedState: string -> string
    /// Use to log out the current user, and redirect the user to the postLogoutRedirectUri.
    /// Default behaviour is to redirect the user to `window.location.href`.
    abstract getLogoutUri: logoutRequest: EndSessionRequest -> string

/// Oauth2.0 Authorization Code client
type [<AllowNullLiteral>] AuthorizationCodeClientStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: ClientConfiguration -> AuthorizationCodeClient

type [<AllowNullLiteral>] AuthorizationCodeRequest =
    inherit BaseAuthRequest
    abstract redirectUri: string with get, set
    abstract code: string with get, set
    abstract codeVerifier: string option with get, set
    abstract authenticationScheme: AuthenticationScheme option with get, set

type [<AllowNullLiteral>] AuthorizationUrlRequest =
    inherit BaseAuthRequest
    abstract authenticationScheme: AuthenticationScheme option with get,set
    abstract redirectUri: string option with get,set
    abstract extraScopesToConsent: Array<string> option with get,set
    abstract responseMode: ResponseMode option with get,set
    abstract codeChallenge: string option with get,set
    abstract codeChallengeMethod: string option with get,set
    abstract state: string option with get,set
    abstract prompt: string option with get,set
    abstract account: AccountInfo option with get,set
    abstract loginHint: string option with get,set
    abstract domainHint: string option with get,set
    abstract sid: string option with get,set
    abstract extraQueryParameters: StringDict option with get,set
    abstract nonce: string option with get,set

/// JWT Token representation class. Parses token string and generates claims object.
type [<AllowNullLiteral>] AuthToken =
    abstract rawToken: string with get, set
    abstract claims: TokenClaims with get, set

/// JWT Token representation class. Parses token string and generates claims object.
type [<AllowNullLiteral>] AuthTokenStatic =
    [<Emit "new $0($1...)">] abstract Create: rawToken: string * crypto: ICrypto -> AuthToken
    /// Extract token by decoding the rawToken
    abstract extractTokenClaims: encodedToken: string * crypto: ICrypto -> TokenClaims

type [<AllowNullLiteral>] BaseAuthRequest =
    abstract scopes: Array<string> with get, set
    abstract claims: string option with get, set
    abstract authority: string option with get, set
    abstract correlationId: string option with get, set
    abstract resourceRequestMethod: string option with get, set
    abstract resourceRequestUri: string option with get, set

/// Base application class which will construct requests to send to and handle responses from the Microsoft STS using the authorization code flow.
type [<AllowNullLiteral>] BaseClient =
    abstract logger: Logger with get, set
    abstract config: ClientConfiguration with get, set
    abstract cryptoUtils: ICrypto with get, set
    abstract cacheManager: CacheManager with get, set
    abstract networkClient: INetworkModule with get, set
    abstract serverTelemetryManager: ServerTelemetryManager with get, set
    abstract networkManager: NetworkManager with get, set
    abstract authority: Authority with get, set
    /// Creates default headers for requests to token endpoint
    abstract createDefaultTokenRequestHeaders: unit -> Record<string, string>
    /// addLibraryData
    abstract createDefaultLibraryHeaders: unit -> Record<string, string>
    /// Http post to token endpoint
    abstract executePostToTokenEndpoint: tokenEndpoint: string * queryString: string * headers: Record<string, string> * thumbprint: RequestThumbprint -> Promise<NetworkResponse<ServerAuthorizationTokenResponse>>

/// Base application class which will construct requests to send to and handle responses from the Microsoft STS using the authorization code flow.
type [<AllowNullLiteral>] BaseClientStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: ClientConfiguration -> BaseClient

/// Browser library error class thrown by the MSAL.js library for SPAs
type [<AllowNullLiteral;AbstractClass>] BrowserAuthError =
    inherit AuthError

/// Browser library error class thrown by the MSAL.js library for SPAs
type [<AllowNullLiteral>] BrowserAuthErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string -> BrowserAuthError
    /// Creates an error thrown when PKCE is not implemented.
    abstract createPkceNotGeneratedError: errDetail: string -> BrowserAuthError
    /// Creates an error thrown when the crypto object is unavailable.
    abstract createCryptoNotAvailableError: errDetail: string -> BrowserAuthError
    /// Creates an error thrown when an HTTP method hasn't been implemented by the browser class.
    abstract createHttpMethodNotImplementedError: ``method``: string -> BrowserAuthError
    /// Creates an error thrown when the navigation URI is empty.
    abstract createEmptyNavigationUriError: unit -> BrowserAuthError
    /// Creates an error thrown when the hash string value is unexpectedly empty.
    abstract createEmptyHashError: hashValue: string -> BrowserAuthError
    /// Creates an error thrown when a browser interaction (redirect or popup) is in progress.
    abstract createInteractionInProgressError: unit -> BrowserAuthError
    /// Creates an error thrown when the popup window could not be opened.
    abstract createPopupWindowError: ?errDetail: string -> BrowserAuthError
    /// Creates an error thrown when window.open returns an empty window object.
    abstract createEmptyWindowCreatedError: unit -> BrowserAuthError
    /// Creates an error thrown when the user closes a popup.
    abstract createUserCancelledError: unit -> BrowserAuthError
    /// Creates an error thrown when monitorWindowFromHash times out for a given popup.
    abstract createMonitorWindowTimeoutError: unit -> BrowserAuthError
    /// Creates an error thrown when navigateWindow is called inside an iframe.
    abstract createRedirectInIframeError: windowParentCheck: bool -> BrowserAuthError
    /// Creates an error thrown when an auth reload is done inside an iframe.
    abstract createBlockReloadInHiddenIframeError: unit -> BrowserAuthError
    /// Creates an error thrown when an iframe is found to be closed before the timeout is reached.
    abstract createIframeClosedPrematurelyError: unit -> BrowserAuthError
    /// Creates an error thrown when the login_hint, sid or account object is not provided in the ssoSilent API.
    abstract createSilentSSOInsufficientInfoError: unit -> BrowserAuthError
    /// Creates an error thrown when a given prompt value is invalid for silent requests.
    abstract createSilentPromptValueError: givenPrompt: string -> BrowserAuthError
    /// Creates an error thrown when the token request could not be retrieved from the cache
    abstract createTokenRequestCacheError: errDetail: string -> BrowserAuthError
    /// Creates an error thrown if cache type is invalid.
    abstract createInvalidCacheTypeError: unit -> BrowserAuthError
    /// Create an error thrown when login and token requests are made from a non-browser environment
    abstract createNonBrowserEnvironmentError: unit -> BrowserAuthError

type [<AllowNullLiteral>] BrowserAuthOptions =
    abstract clientId: string with get, set
    abstract authority: string option with get, set
    abstract knownAuthorities: Array<string> option with get, set
    abstract cloudDiscoveryMetadata: string option with get, set
    abstract redirectUri: string option with get, set
    abstract postLogoutRedirectUri: string option with get, set
    abstract navigateToLoginRequestUrl: bool option with get, set
    abstract clientCapabilities: Array<string> option with get, set

/// Browser library error class thrown by the MSAL.js library for SPAs
type [<AllowNullLiteral;AbstractClass>] BrowserConfigurationAuthError =
    inherit AuthError

/// Browser library error class thrown by the MSAL.js library for SPAs
type [<AllowNullLiteral>] BrowserConfigurationAuthErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string -> BrowserConfigurationAuthError
    /// Creates an error thrown when the redirect uri is empty (not set by caller)
    abstract createRedirectUriEmptyError: unit -> BrowserConfigurationAuthError
    /// Creates an error thrown when the post-logout redirect uri is empty (not set by caller)
    abstract createPostLogoutRedirectUriEmptyError: unit -> BrowserConfigurationAuthError
    /// Creates error thrown when given storage location is not supported.
    abstract createStorageNotSupportedError: givenStorageLocation: string -> BrowserConfigurationAuthError
    /// Creates error thrown when callback object is invalid.
    abstract createInvalidCallbackObjectError: callbackObject: obj -> BrowserConfigurationAuthError
    /// Creates error thrown when redirect callbacks are not set before calling loginRedirect() or acquireTokenRedirect().
    abstract createRedirectCallbacksNotSetError: unit -> BrowserConfigurationAuthError

/// This class implements the cache storage interface for MSAL through browser local or session storage.
/// Cookies are only used if storeAuthStateInCookie is true, and are only used for
/// parameters such as state and nonce, generally.
type [<AllowNullLiteral>] BrowserStorage =
    inherit CacheManager
    /// Sets the cache item with the key and value given.
    /// Stores in cookie if storeAuthStateInCookie is set to true.
    /// This can cause cookie overflow if used incorrectly.
    abstract setItem: key: string * value: U2<string, obj> * ``type``: string -> unit
    /// Gets cache item with given key.
    /// Will retrieve frm cookies if storeAuthStateInCookie is set to true.
    abstract getItem: key: string * ``type``: string -> U2<string, obj>
    /// Removes the cache item with the given key.
    /// Will also clear the cookie item if storeAuthStateInCookie is set to true.
    abstract removeItem: key: string -> bool
    /// Checks whether key is in cache.
    abstract containsKey: key: string -> bool
    /// Gets all keys in window.
    abstract getKeys: unit -> ResizeArray<string>
    /// Clears all cache entries created by MSAL (except tokens).
    abstract clear: unit -> unit
    /// Add value to cookies
    abstract setItemCookie: cookieName: string * cookieValue: string * ?expires: float -> unit
    /// Get one item by key from cookies
    abstract getItemCookie: cookieName: string -> string
    /// Clear an item in the cookies by key
    abstract clearItemCookie: cookieName: string -> unit
    /// Clear all msal cookies
    abstract clearMsalCookie: ?stateString: string -> unit
    /// Get cookie expiration time
    abstract getCookieExpirationTime: cookieLifeDays: float -> string
    /// Gets the cache object referenced by the browser
    abstract getCache: unit -> obj
    /// interface compat, we cannot overwrite browser cache; Functionality is supported by individual entities in browser
    abstract setCache: unit -> unit
    /// Prepend msal.<client-id> to each key; Skip for any JSON object as Key (defined schemas do not need the key appended: AccessToken Keys or the upcoming schema)
    abstract generateCacheKey: key: string -> string
    /// Create authorityKey to cache authority
    abstract generateAuthorityKey: stateString: string -> string
    /// Create Nonce key to cache nonce
    abstract generateNonceKey: stateString: string -> string
    /// <summary>Creates full cache key for the request state</summary>
    /// <param name="stateString">State string for the request</param>
    abstract generateStateKey: stateString: string -> string
    /// Sets the cacheKey for and stores the authority information in cache
    abstract setAuthorityCache: authority: string * state: string -> unit
    /// Gets the cached authority based on the cached state. Returns empty if no cached state found.
    abstract getCachedAuthority: cachedState: string -> string
    /// Updates account, authority, and state in cache
    abstract updateCacheEntries: state: string * nonce: string * authorityInstance: string -> unit
    /// Reset all temporary cache items
    abstract resetRequestCache: state: string -> unit
    abstract cleanRequest: ?stateString: string -> unit
    abstract cacheCodeRequest: authCodeRequest: AuthorizationCodeRequest * browserCrypto: ICrypto -> unit
    /// Gets the token exchange parameters from the cache. Throws an error if nothing is found.
    abstract getCachedRequest: state: string * browserCrypto: ICrypto -> AuthorizationCodeRequest

/// This class implements the cache storage interface for MSAL through browser local or session storage.
/// Cookies are only used if storeAuthStateInCookie is true, and are only used for
/// parameters such as state and nonce, generally.
type [<AllowNullLiteral>] BrowserStorageStatic =
    [<Emit "new $0($1...)">] abstract Create: clientId: string * cacheConfig: CacheOptions * cryptoImpl: CryptoOps -> BrowserStorage

type [<AllowNullLiteral>] BrowserSystemOptions =
    interface end

/// Interface class which implement cache storage functions used by MSAL to perform validity checks, and store tokens.
type [<AllowNullLiteral>] CacheManager =
    inherit ICacheManager
    /// Function to set item in cache.
    abstract setItem: key: string * value: U2<string, obj> * ?``type``: string -> unit
    /// Function which retrieves item from cache.
    abstract getItem: key: string * ?``type``: string -> U2<string, obj>
    /// Function to remove an item from cache given its key.
    abstract removeItem: key: string * ?``type``: string -> bool
    /// Function which returns boolean whether cache contains a specific key.
    abstract containsKey: key: string * ?``type``: string -> bool
    /// Function which retrieves all current keys from the cache.
    abstract getKeys: unit -> ResizeArray<string>
    /// Function which clears cache.
    abstract clear: unit -> unit
    /// Returns all accounts in cache
    abstract getAllAccounts: unit -> ResizeArray<AccountInfo>
    /// saves a cache record
    abstract saveCacheRecord: cacheRecord: CacheRecord -> unit
    /// retrieve an account entity given the cache key
    abstract getAccount: key: string -> AccountEntity option
    /// retrieve a credential - accessToken, idToken or refreshToken; given the cache key
    abstract getCredential: key: string -> CredentialEntity option
    /// retrieve an appmetadata entity given the cache key
    abstract getAppMetadata: key: string -> AppMetadataEntity option
    /// retrieve accounts matching all provided filters; if no filter is set, get all accounts
    /// not checking for casing as keys are all generated in lower case, remember to convert to lower case if object properties are compared
    abstract getAccountsFilteredBy: ?accountFilter: AccountFilter -> AccountCache
    /// retrieve credentails matching all provided filters; if no filter is set, get all credentials
    abstract getCredentialsFilteredBy: filter: CredentialFilter -> CredentialCache
    /// Removes all accounts and related tokens from cache.
    abstract removeAllAccounts: unit -> bool
    /// returns a boolean if the given account is removed
    abstract removeAccount: accountKey: string -> bool
    /// returns a boolean if the given account is removed
    abstract removeAccountContext: account: AccountEntity -> bool
    /// returns a boolean if the given credential is removed
    abstract removeCredential: credential: CredentialEntity -> bool
    /// Removes all app metadata objects from cache.
    abstract removeAppMetadata: unit -> bool
    /// Retrieve the cached credentials into a cacherecord
    abstract readCacheRecord: account: AccountInfo * clientId: string * scopes: ScopeSet * environment: string -> CacheRecord
    /// Retrieve AccountEntity from cache
    abstract readAccountFromCache: account: AccountInfo -> AccountEntity option
    /// Retrieve IdTokenEntity from cache
    abstract readIdTokenFromCache: clientId: string * account: AccountInfo -> IdTokenEntity option
    /// Retrieve AccessTokenEntity from cache
    abstract readAccessTokenFromCache: clientId: string * account: AccountInfo * scopes: ScopeSet -> AccessTokenEntity option
    /// Helper to retrieve the appropriate refresh token from cache
    abstract readRefreshTokenFromCache: clientId: string * account: AccountInfo * familyRT: bool -> RefreshTokenEntity option
    /// Retrieve AppMetadataEntity from cache
    abstract readAppMetadataFromCache: environment: string * clientId: string -> AppMetadataEntity
    /// Return the family_id value associated  with FOCI
    abstract isAppMetadataFOCI: environment: string * clientId: string -> bool

/// Interface class which implement cache storage functions used by MSAL to perform validity checks, and store tokens.
type [<AllowNullLiteral>] CacheManagerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CacheManager
    /// Helper to convert serialized data to object
    abstract toObject: obj: 'T * json: obj -> 'T

type [<AllowNullLiteral>] CacheOptions =
    abstract cacheLocation: string option with get, set
    abstract storeAuthStateInCookie: bool option with get, set

type [<AllowNullLiteral>] CacheRecord =
    abstract account: AccountEntity with get, set
    abstract idToken: IdTokenEntity with get, set
    abstract accessToken: AccessTokenEntity with get, set
    abstract refreshToken: RefreshTokenEntity with get, set
    abstract appMetadata: AppMetadataEntity with get, set

type [<AllowNullLiteral>] CacheRecordStatic =
    [<Emit "new $0($1...)">] abstract Create: ?accountEntity: AccountEntity * ?idTokenEntity: IdTokenEntity * ?accessTokenEntity: AccessTokenEntity * ?refreshTokenEntity: RefreshTokenEntity * ?appMetadataEntity: AppMetadataEntity -> CacheRecord

type [<AllowNullLiteral>] ClientApplication =
    abstract browserCrypto: CryptoOps
    abstract browserStorage: BrowserStorage
    abstract networkClient: INetworkModule
    abstract tokenExchangePromise: Promise<AuthenticationResult>
    abstract config: Configuration with get, set
    abstract defaultAuthority: Authority with get, set
    abstract logger: Logger with get, set
    abstract isBrowserEnvironment: bool with get, set
    /// Event handler function which allows users to fire events after the PublicClientApplication object
    /// has loaded during redirect flows. This should be invoked on all page loads involved in redirect
    /// auth flows.
    abstract handleRedirectPromise: unit -> Promise<AuthenticationResult option>
    /// Use when you want to obtain an access_token for your API by redirecting the user's browser window to the authorization endpoint. This function redirects
    /// the page, so any code that follows this function will not execute.
    /// 
    /// IMPORTANT: It is NOT recommended to have code that is dependent on the resolution of the Promise. This function will navigate away from the current
    /// browser window. It currently returns a Promise in order to reflect the asynchronous nature of the code running in this function.
    abstract acquireTokenRedirect: request: RedirectRequest -> Promise<unit>
    /// Use when you want to obtain an access_token for your API via opening a popup window in the user's browser
    abstract acquireTokenPopup: request: PopupRequest -> Promise<AuthenticationResult>
    /// This function uses a hidden iframe to fetch an authorization code from the eSTS. There are cases where this may not work:
    /// - Any browser using a form of Intelligent Tracking Prevention
    /// - If there is not an established session with the service
    /// 
    /// In these cases, the request must be done inside a popup or full frame redirect.
    /// 
    /// For the cases where interaction is required, you cannot send a request with prompt=none.
    /// 
    /// If your refresh token has expired, you can use this function to fetch a new set of tokens silently as long as
    /// you session on the server still exists.
    abstract ssoSilent: request: SsoSilentRequest -> Promise<AuthenticationResult>
    /// Use this function to obtain a token before every call to the API / resource provider
    /// 
    /// MSAL return's a cached token when available
    /// Or it send's a request to the STS to obtain a new token using a refresh token.
    abstract acquireTokenByRefreshToken: request: SilentRequest -> Promise<AuthenticationResult>
    /// Use to log out the current user, and redirect the user to the postLogoutRedirectUri.
    /// Default behaviour is to redirect the user to `window.location.href`.
    abstract logout: ?logoutRequest: EndSessionRequest -> Promise<unit>
    /// Returns all accounts that MSAL currently has data for.
    /// (the account object is created at the time of successful login)
    /// or empty array when no accounts are found
    abstract getAllAccounts: unit -> ResizeArray<AccountInfo>
    /// Returns the signed in account matching username.
    /// (the account object is created at the time of successful login)
    /// or null when no matching account is found.
    /// This API is provided for convenience but getAccountById should be used for best reliability
    abstract getAccountByUsername: userName: string -> AccountInfo option
    /// Returns the signed in account matching homeAccountId.
    /// (the account object is created at the time of successful login)
    /// or null when no matching account is found
    abstract getAccountByHomeId: homeAccountId: string -> AccountInfo option
    /// Use to get the redirect uri configured in MSAL or null.
    abstract getRedirectUri: ?requestRedirectUri: string -> string
    /// Use to get the post logout redirect uri configured in MSAL or null.
    abstract getPostLogoutRedirectUri: ?requestPostLogoutRedirectUri: string -> string
    /// Used to get a discovered version of the default authority.
    abstract getDiscoveredDefaultAuthority: unit -> Promise<Authority>
    /// Helper to check whether interaction is in progress.
    abstract interactionInProgress: unit -> bool
    /// Creates an Authorization Code Client with the given authority, or the default authority.
    abstract createAuthCodeClient: serverTelemetryManager: ServerTelemetryManager * ?authorityUrl: string -> Promise<AuthorizationCodeClient>
    /// Creates an Silent Flow Client with the given authority, or the default authority.
    abstract createSilentFlowClient: serverTelemetryManager: ServerTelemetryManager * ?authorityUrl: string -> Promise<SilentFlowClient>
    /// Creates a Refresh Client with the given authority, or the default authority.
    abstract createRefreshTokenClient: serverTelemetryManager: ServerTelemetryManager * ?authorityUrl: string -> Promise<RefreshTokenClient>
    /// Creates a Client Configuration object with the given request authority, or the default authority.
    abstract getClientConfiguration: serverTelemetryManager: ServerTelemetryManager * ?requestAuthority: string -> Promise<ClientConfiguration>
    /// Helper to validate app environment before making a request.
    abstract preflightInteractiveRequest: request: U2<RedirectRequest, PopupRequest> * interactionType: InteractionType -> AuthorizationUrlRequest
    /// Helper to validate app environment before making a silent request
    /// * @param request
    abstract preflightBrowserEnvironmentCheck: unit -> unit
    /// Initializer function for all request APIs
    abstract initializeBaseRequest: request: BaseAuthRequest -> BaseAuthRequest
    abstract initializeServerTelemetryManager: apiId: float * correlationId: string * ?forceRefresh: bool -> ServerTelemetryManager
    /// Generates a request that will contain the openid and profile scopes.
    abstract setDefaultScopes: request: U4<AuthorizationUrlRequest, RedirectRequest, PopupRequest, SsoSilentRequest> -> AuthorizationUrlRequest
    /// Helper to initialize required request parameters for interactive APIs and ssoSilent()
    abstract initializeAuthorizationRequest: request: U4<AuthorizationUrlRequest, RedirectRequest, PopupRequest, SsoSilentRequest> * interactionType: InteractionType -> AuthorizationUrlRequest
    /// Generates an auth code request tied to the url request.
    abstract initializeAuthorizationCodeRequest: request: AuthorizationUrlRequest -> Promise<AuthorizationCodeRequest>
    /// Initializer for the logout request.
    abstract initializeLogoutRequest: ?logoutRequest: EndSessionRequest -> EndSessionRequest

type [<AllowNullLiteral>] ClientApplicationStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: Configuration -> ClientApplication

type [<AllowNullLiteral>] ClientConfiguration =
    abstract authOptions: AuthOptions with get, set
    abstract systemOptions: SystemOptions option with get, set
    abstract loggerOptions: LoggerOptions option with get, set
    abstract storageInterface: CacheManager option with get, set
    abstract networkInterface: INetworkModule option with get, set
    abstract cryptoInterface: ICrypto option with get, set
    abstract clientCredentials: ClientCredentials option with get, set
    abstract libraryInfo: LibraryInfo option with get, set
    abstract serverTelemetryManager: ServerTelemetryManager option with get, set

type [<AllowNullLiteral>] ClientCredentials =
    abstract clientSecret: string option with get, set
    abstract clientAssertion: ClientCredentialsClientAssertion option with get, set

type [<AllowNullLiteral>] Configuration =
    abstract auth: BrowserAuthOptions option with get, set
    abstract cache: CacheOptions option with get, set
    abstract system: BrowserSystemOptions option with get, set

type [<AllowNullLiteral>] CredentialCache =
    abstract idTokens: IdTokenCache with get, set
    abstract accessTokens: AccessTokenCache with get, set
    abstract refreshTokens: RefreshTokenCache with get, set

/// Base type for credentials to be stored in the cache: eg: ACCESS_TOKEN, ID_TOKEN etc
/// 
/// Key:Value Schema:
/// 
/// Key: <home_account_id*>-<environment>-<credential_type>-<client_id>-<realm*>-<target*>
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, usually only used for refresh tokens
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
///       oboAssertion: access token passed in as part of OBO request
/// }
type [<AllowNullLiteral>] CredentialEntity =
    abstract homeAccountId: string with get, set
    abstract environment: string with get, set
    abstract credentialType: CredentialType with get, set
    abstract clientId: string with get, set
    abstract secret: string with get, set
    abstract familyId: string option with get, set
    abstract realm: string option with get, set
    abstract target: string option with get, set
    abstract oboAssertion: string option with get, set
    /// Generate Account Id key component as per the schema: <home_account_id>-<environment>
    abstract generateAccountId: unit -> string
    /// Generate Credential Id key component as per the schema: <credential_type>-<client_id>-<realm>
    abstract generateCredentialId: unit -> string
    /// Generate target key component as per schema: <target>
    abstract generateTarget: unit -> string
    /// generates credential key
    abstract generateCredentialKey: unit -> string
    /// returns the type of the cache (in this case credential)
    abstract generateType: unit -> float

/// Base type for credentials to be stored in the cache: eg: ACCESS_TOKEN, ID_TOKEN etc
/// 
/// Key:Value Schema:
/// 
/// Key: <home_account_id*>-<environment>-<credential_type>-<client_id>-<realm*>-<target*>
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, usually only used for refresh tokens
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
///       oboAssertion: access token passed in as part of OBO request
/// }
type [<AllowNullLiteral>] CredentialEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CredentialEntity
    /// helper function to return `CredentialType`
    abstract getCredentialType: key: string -> string
    /// generates credential key
    abstract generateCredentialCacheKey: homeAccountId: string * environment: string * credentialType: CredentialType * clientId: string * ?realm: string * ?target: string * ?familyId: string -> string

type [<AllowNullLiteral>] CredentialFilter =
    abstract homeAccountId: string option with get, set
    abstract environment: string option with get, set
    abstract credentialType: string option with get, set
    abstract clientId: string option with get, set
    abstract familyId: string option with get, set
    abstract realm: string option with get, set
    abstract target: string option with get, set
    abstract oboAssertion: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] CredentialType =
    | [<CompiledName "IdToken">] ID_TOKEN
    | [<CompiledName "AccessToken">] ACCESS_TOKEN
    | [<CompiledName "RefreshToken">] REFRESH_TOKEN

/// This class implements MSAL's crypto interface, which allows it to perform base64 encoding and decoding, generating cryptographically random GUIDs and
/// implementing Proof Key for Code Exchange specs for the OAuth Authorization Code Flow using PKCE (rfc here: https://tools.ietf.org/html/rfc7636).
type [<AllowNullLiteral>] CryptoOps =
    inherit ICrypto
    /// Creates a new random GUID - used to populate state and nonce.
    abstract createNewGuid: unit -> string
    /// Encodes input string to base64.
    abstract base64Encode: input: string -> string
    /// Decodes input string from base64.
    abstract base64Decode: input: string -> string
    /// Generates PKCE codes used in Authorization Code Flow.
    abstract generatePkceCodes: unit -> Promise<PkceCodes>
    /// Generates a keypair, stores it and returns a thumbprint
    abstract getPublicKeyThumbprint: resourceRequestMethod: string * resourceRequestUri: string -> Promise<string>
    /// Signs the given object as a jwt payload with private key retrieved by given kid.
    abstract signJwt: payload: SignedHttpRequest * kid: string -> Promise<string>

/// This class implements MSAL's crypto interface, which allows it to perform base64 encoding and decoding, generating cryptographically random GUIDs and
/// implementing Proof Key for Code Exchange specs for the OAuth Authorization Code Flow using PKCE (rfc here: https://tools.ietf.org/html/rfc7636).
type [<AllowNullLiteral>] CryptoOpsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CryptoOps

type [<AllowNullLiteral>] EndSessionRequest =
    abstract account: AccountInfo option with get, set
    abstract postLogoutRedirectUri: string option with get, set
    abstract authority: string option with get, set
    abstract correlationId: string option with get, set

type [<AllowNullLiteral>] ICacheManager =
    /// Returns all accounts in cache
    abstract getAllAccounts: unit -> ResizeArray<AccountInfo>
    /// saves a cache record
    abstract saveCacheRecord: cacheRecord: CacheRecord -> unit
    /// Given account key retrieve an account
    abstract getAccount: key: string -> AccountEntity option
    /// retrieve a credential - accessToken, idToken or refreshToken; given the cache key
    abstract getCredential: key: string -> CredentialEntity option
    /// retrieve appMetadata, given the cache key
    abstract getAppMetadata: key: string -> AppMetadataEntity option
    /// retrieve accounts matching all provided filters; if no filter is set, get all accounts
    abstract getAccountsFilteredBy: filter: AccountFilter -> AccountCache
    /// retrieve credentials matching all provided filters; if no filter is set, get all credentials
    abstract getCredentialsFilteredBy: filter: CredentialFilter -> CredentialCache
    /// Removes all accounts and related tokens from cache.
    abstract removeAllAccounts: unit -> bool
    /// returns a boolean if the given account is removed
    abstract removeAccount: accountKey: string -> bool
    /// returns a boolean if the given account is removed
    abstract removeAccountContext: account: AccountEntity -> bool
    /// returns a boolean if the given credential is removed
    abstract removeCredential: credential: CredentialEntity -> bool

/// Interface for crypto functions used by library
type [<AllowNullLiteral>] ICrypto =
    /// Creates a guid randomly.
    abstract createNewGuid: unit -> string
    /// base64 Encode string
    abstract base64Encode: input: string -> string
    /// base64 decode string
    abstract base64Decode: input: string -> string
    /// Generate PKCE codes for OAuth. See RFC here: https://tools.ietf.org/html/rfc7636
    abstract generatePkceCodes: unit -> Promise<PkceCodes>
    /// Generates an JWK RSA S256 Thumbprint
    abstract getPublicKeyThumbprint: resourceRequestMethod: string * resourceRequestUri: string -> Promise<string>
    /// Returns a signed proof-of-possession token with a given acces token that contains a cnf claim with the required kid.
    abstract signJwt: payload: SignedHttpRequest * kid: string -> Promise<string>

type IdTokenCache =
    Record<string, IdTokenEntity>

/// ID_TOKEN Cache
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-idtoken-clientId-contoso.com-
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       realm: Full tenant or organizational identifier that the account belongs to
/// }
type [<AllowNullLiteral>] IdTokenEntity =
    inherit CredentialEntity
    abstract realm: string with get, set

/// ID_TOKEN Cache
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-idtoken-clientId-contoso.com-
/// 
/// Value Schema:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       realm: Full tenant or organizational identifier that the account belongs to
/// }
type [<AllowNullLiteral>] IdTokenEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IdTokenEntity
    /// Create IdTokenEntity
    abstract createIdTokenEntity: homeAccountId: string * environment: string * idToken: string * clientId: string * tenantId: string * ?oboAssertion: string -> IdTokenEntity
    /// Validates an entity: checks for all expected params
    abstract isIdTokenEntity: entity: obj -> bool

/// Callback to send the messages to.
type [<AllowNullLiteral>] ILoggerCallback =
    [<Emit "$0($1...)">] abstract Invoke: level: LogLevel * message: string * containsPii: bool -> unit

/// Client network interface to send backend requests.
type [<AllowNullLiteral>] INetworkModule =
    /// Interface function for async network "GET" requests. Based on the Fetch standard: https://fetch.spec.whatwg.org/
    abstract sendGetRequestAsync: url: string * ?options: NetworkRequestOptions -> Promise<NetworkResponse<'T>>
    /// Interface function for async network "POST" requests. Based on the Fetch standard: https://fetch.spec.whatwg.org/
    abstract sendPostRequestAsync: url: string * ?options: NetworkRequestOptions -> Promise<NetworkResponse<'T>>

/// Error thrown when user interaction is required at the auth server.
type [<AllowNullLiteral;AbstractClass>] InteractionRequiredAuthError =
    inherit ServerError

/// Error thrown when user interaction is required at the auth server.
type [<AllowNullLiteral>] InteractionRequiredAuthErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string * ?subError: string -> InteractionRequiredAuthError
    abstract isInteractionRequiredError: errorCode: string * errorString: string * ?subError: string -> bool

type [<StringEnum>] [<RequireQualifiedAccess>] InteractionType =
    | [<CompiledName "redirect">] REDIRECT
    | [<CompiledName "popup">] POPUP
    | [<CompiledName "silent">] SILENT

type [<AllowNullLiteral>] IPublicClientApplication =
    abstract acquireTokenPopup: request: PopupRequest -> Promise<AuthenticationResult>
    abstract acquireTokenRedirect: request: RedirectRequest -> Promise<unit>
    abstract acquireTokenSilent: silentRequest: SilentRequest -> Promise<AuthenticationResult>
    abstract getAccountByUsername: userName: string -> AccountInfo option
    abstract getAccountByHomeId: homeAccountId: string -> AccountInfo option
    abstract getAllAccounts: unit -> ResizeArray<AccountInfo>
    abstract handleRedirectPromise: unit -> Promise<AuthenticationResult option>
    abstract loginPopup: ?request: PopupRequest -> Promise<AuthenticationResult>
    abstract loginRedirect: ?request: RedirectRequest -> Promise<unit>
    abstract logout: ?logoutRequest: EndSessionRequest -> Promise<unit>
    abstract ssoSilent: request: SsoSilentRequest -> Promise<AuthenticationResult>

/// Interface which describes URI components.
type [<AllowNullLiteral>] IUri =
    abstract Protocol: string with get, set
    abstract HostNameAndPort: string with get, set
    abstract AbsolutePath: string with get, set
    abstract Search: string with get, set
    abstract Hash: string with get, set
    abstract PathSegments: ResizeArray<string> with get, set
    abstract QueryString: string with get, set

type [<AllowNullLiteral>] LibraryInfo =
    abstract sku: string with get, set
    abstract version: string with get, set
    abstract cpu: string with get, set
    abstract os: string with get, set

/// Class which facilitates logging of messages to a specific place.
type [<AllowNullLiteral>] Logger =
    /// Execute callback with message.
    abstract executeCallback: level: LogLevel * message: string * containsPii: bool -> unit
    /// Logs error messages.
    abstract error: message: string * ?correlationId: string -> unit
    /// Logs error messages with PII.
    abstract errorPii: message: string * ?correlationId: string -> unit
    /// Logs warning messages.
    abstract warning: message: string * ?correlationId: string -> unit
    /// Logs warning messages with PII.
    abstract warningPii: message: string * ?correlationId: string -> unit
    /// Logs info messages.
    abstract info: message: string * ?correlationId: string -> unit
    /// Logs info messages with PII.
    abstract infoPii: message: string * ?correlationId: string -> unit
    /// Logs verbose messages.
    abstract verbose: message: string * ?correlationId: string -> unit
    /// Logs verbose messages with PII.
    abstract verbosePii: message: string * ?correlationId: string -> unit
    /// Returns whether PII Logging is enabled or not.
    abstract isPiiLoggingEnabled: unit -> bool

/// Class which facilitates logging of messages to a specific place.
type [<AllowNullLiteral>] LoggerStatic =
    [<Emit "new $0($1...)">] abstract Create: loggerOptions: LoggerOptions -> Logger

type [<AllowNullLiteral>] LoggerOptions =
    abstract loggerCallback: ILoggerCallback option with get, set
    abstract piiLoggingEnabled: bool option with get, set
    abstract logLevel: LogLevel option with get, set

type [<RequireQualifiedAccess>] LogLevel =
    | Error = 0
    | Warning = 1
    | Info = 2
    | Verbose = 3

type [<AllowNullLiteral>] NetworkManager =
    /// Wraps sendPostRequestAsync with necessary preflight and postflight logic
    abstract sendPostRequest: thumbprint: RequestThumbprint * tokenEndpoint: string * options: NetworkRequestOptions -> Promise<NetworkResponse<'T>>

type [<AllowNullLiteral>] NetworkManagerStatic =
    [<Emit "new $0($1...)">] abstract Create: networkClient: INetworkModule * cacheManager: CacheManager -> NetworkManager

type [<AllowNullLiteral>] NetworkRequestOptions =
    abstract headers: Record<string, string> option with get, set
    abstract body: string option with get, set

type [<AllowNullLiteral>] NetworkResponse<'T> =
    abstract headers: Record<string, string> with get, set
    abstract body: 'T with get, set
    abstract status: float with get, set

type [<AllowNullLiteral>] PkceCodes =
    abstract verifier: string with get, set
    abstract challenge: string with get, set

type PopupRequest =
    AuthorizationUrlRequest

/// The PublicClientApplication class is the object exposed by the library to perform authentication and authorization functions in Single Page Applications
/// to obtain JWT tokens as described in the OAuth 2.0 Authorization Code Flow with PKCE specification.
type [<AllowNullLiteral>] PublicClientApplication =
    inherit ClientApplication
    inherit IPublicClientApplication
    /// Use when initiating the login process by redirecting the user's browser to the authorization endpoint. This function redirects the page, so
    /// any code that follows this function will not execute.
    /// 
    /// IMPORTANT: It is NOT recommended to have code that is dependent on the resolution of the Promise. This function will navigate away from the current
    /// browser window. It currently returns a Promise in order to reflect the asynchronous nature of the code running in this function.
    abstract loginRedirect: ?request: RedirectRequest -> Promise<unit>
    /// Use when initiating the login process via opening a popup window in the user's browser
    abstract loginPopup: ?request: PopupRequest -> Promise<AuthenticationResult>
    abstract acquireTokenSilent: request: SilentRequest -> Promise<AuthenticationResult>

/// The PublicClientApplication class is the object exposed by the library to perform authentication and authorization functions in Single Page Applications
/// to obtain JWT tokens as described in the OAuth 2.0 Authorization Code Flow with PKCE specification.
type [<AllowNullLiteral>] PublicClientApplicationStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: Configuration -> PublicClientApplication

type [<AllowNullLiteral>] RedirectRequest =
    inherit AuthorizationUrlRequest
    abstract redirectStartPage: string option with get, set

type RefreshTokenCache =
    Record<string, RefreshTokenEntity>

/// OAuth2.0 refresh token client
type [<AllowNullLiteral>] RefreshTokenClient =
    inherit BaseClient
    abstract acquireToken: request: RefreshTokenRequest -> Promise<AuthenticationResult>
    /// Gets cached refresh token and attaches to request, then calls acquireToken API
    abstract acquireTokenByRefreshToken: request: SilentFlowRequest -> Promise<AuthenticationResult>

/// OAuth2.0 refresh token client
type [<AllowNullLiteral>] RefreshTokenClientStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: ClientConfiguration -> RefreshTokenClient

/// REFRESH_TOKEN Cache
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-refreshtoken-clientId--
/// 
/// Value:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, '1' represents Microsoft Family
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
/// }
type [<AllowNullLiteral>] RefreshTokenEntity =
    inherit CredentialEntity
    abstract familyId: string option with get, set

/// REFRESH_TOKEN Cache
/// 
/// Key:Value Schema:
/// 
/// Key Example: uid.utid-login.microsoftonline.com-refreshtoken-clientId--
/// 
/// Value:
/// {
///       homeAccountId: home account identifier for the auth scheme,
///       environment: entity that issued the token, represented as a full host
///       credentialType: Type of credential as a string, can be one of the following: RefreshToken, AccessToken, IdToken, Password, Cookie, Certificate, Other
///       clientId: client ID of the application
///       secret: Actual credential as a string
///       familyId: Family ID identifier, '1' represents Microsoft Family
///       realm: Full tenant or organizational identifier that the account belongs to
///       target: Permissions that are included in the token, or for refresh tokens, the resource identifier.
/// }
type [<AllowNullLiteral>] RefreshTokenEntityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> RefreshTokenEntity
    /// Create RefreshTokenEntity
    abstract createRefreshTokenEntity: homeAccountId: string * environment: string * refreshToken: string * clientId: string * ?familyId: string * ?oboAssertion: string -> RefreshTokenEntity
    /// Validates an entity: checks for all expected params
    abstract isRefreshTokenEntity: entity: obj -> bool

type [<AllowNullLiteral>] RefreshTokenRequest =
    interface end

type [<AllowNullLiteral>] RequestThumbprint =
    abstract clientId: string with get, set
    abstract authority: string with get, set
    abstract scopes: Array<string> with get, set
    abstract homeAccountIdentifier: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ResponseMode =
    | [<CompiledName "query">] QUERY
    | [<CompiledName "fragment">] FRAGMENT
    | [<CompiledName "form_post">] FORM_POST

/// The ScopeSet class creates a set of scopes. Scopes are case-insensitive, unique values, so the Set object in JS makes
/// the most sense to implement for this class. All scopes are trimmed and converted to lower case strings in intersection and union functions
/// to ensure uniqueness of strings.
type [<AllowNullLiteral>] ScopeSet =
    /// Check if a given scope is present in this set of scopes.
    abstract containsScope: scope: string -> bool
    /// Check if a set of scopes is present in this set of scopes.
    abstract containsScopeSet: scopeSet: ScopeSet -> bool
    /// Check if set of scopes contains only the defaults
    abstract containsOnlyDefaultScopes: unit -> bool
    /// Appends single scope if passed
    abstract appendScope: newScope: string -> unit
    /// Appends multiple scopes if passed
    abstract appendScopes: newScopes: Array<string> -> unit
    /// Removes element from set of scopes.
    abstract removeScope: scope: string -> unit
    /// Removes default scopes from set of scopes
    /// Primarily used to prevent cache misses if the default scopes are not returned from the server
    abstract removeDefaultScopes: unit -> unit
    /// Combines an array of scopes with the current set of scopes.
    abstract unionScopeSets: otherScopes: ScopeSet -> Set<string>
    /// Check if scopes intersect between this set and another.
    abstract intersectingScopeSets: otherScopes: ScopeSet -> bool
    /// Returns size of set of scopes.
    abstract getScopeCount: unit -> float
    /// Returns the scopes as an array of string values
    abstract asArray: unit -> Array<string>
    /// Prints scopes into a space-delimited string
    abstract printScopes: unit -> string
    /// Prints scopes into a space-delimited lower-case string (used for caching)
    abstract printScopesLowerCase: unit -> string

/// The ScopeSet class creates a set of scopes. Scopes are case-insensitive, unique values, so the Set object in JS makes
/// the most sense to implement for this class. All scopes are trimmed and converted to lower case strings in intersection and union functions
/// to ensure uniqueness of strings.
type [<AllowNullLiteral>] ScopeSetStatic =
    [<Emit "new $0($1...)">] abstract Create: inputScopes: Array<string> -> ScopeSet
    /// Factory method to create ScopeSet from space-delimited string
    abstract fromString: inputScopeString: string -> ScopeSet

type [<AllowNullLiteral>] ServerAuthorizationTokenResponse =
    abstract token_type: string option with get, set
    abstract scope: string option with get, set
    abstract expires_in: float option with get, set
    abstract ext_expires_in: float option with get, set
    abstract access_token: string option with get, set
    abstract refresh_token: string option with get, set
    abstract id_token: string option with get, set
    abstract client_info: string option with get, set
    abstract foci: string option with get, set
    abstract error: string option with get, set
    abstract error_description: string option with get, set
    abstract error_codes: Array<string> option with get, set
    abstract suberror: string option with get, set
    abstract timestamp: string option with get, set
    abstract trace_id: string option with get, set
    abstract correlation_id: string option with get, set

/// Error thrown when there is an error with the server code, for example, unavailability.
type [<AllowNullLiteral;AbstractClass>] ServerError =
    inherit AuthError
    abstract subError: string with get, set

/// Error thrown when there is an error with the server code, for example, unavailability.
type [<AllowNullLiteral>] ServerErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string * ?subError: string -> ServerError

type [<AllowNullLiteral>] ServerTelemetryCacheValue =
    abstract failedRequests: Array<U2<string, float>> with get, set
    abstract errors: ResizeArray<string> with get, set
    abstract errorCount: float with get, set
    abstract cacheHits: float with get, set

type [<AllowNullLiteral>] ServerTelemetryManager =
    abstract generateCurrentRequestHeaderValue: unit -> string
    abstract generateLastRequestHeaderValue: unit -> string
    abstract cacheFailedRequest: error: AuthError -> unit
    abstract incrementCacheHits: unit -> float
    abstract getLastRequests: unit -> ServerTelemetryCacheValue
    abstract clearTelemetryCache: unit -> unit

type [<AllowNullLiteral>] ServerTelemetryManagerStatic =
    [<Emit "new $0($1...)">] abstract Create: telemetryRequest: ServerTelemetryRequest * cacheManager: CacheManager -> ServerTelemetryManager

type [<AllowNullLiteral>] ServerTelemetryRequest =
    abstract clientId: string with get, set
    abstract apiId: float with get, set
    abstract correlationId: string with get, set
    abstract forceRefresh: bool option with get, set

type [<AllowNullLiteral>] SignedHttpRequest =
    abstract at: string option with get, set
    abstract cnf: obj option with get, set
    abstract m: string option with get, set
    abstract u: string option with get, set
    abstract p: string option with get, set
    abstract q: Array<string> * string option with get, set
    abstract ts: string option with get, set
    abstract nonce: string option with get, set

type [<AllowNullLiteral>] SilentFlowClient =
    inherit BaseClient
    /// Retrieves a token from cache if it is still valid, or uses the cached refresh token to renew
    /// the given token and returns the renewed token
    abstract acquireToken: request: SilentFlowRequest -> Promise<AuthenticationResult>
    /// Retrieves token from cache or throws an error if it must be refreshed.
    abstract acquireCachedToken: request: SilentFlowRequest -> Promise<AuthenticationResult>

type [<AllowNullLiteral>] SilentFlowClientStatic =
    [<Emit "new $0($1...)">] abstract Create: configuration: ClientConfiguration -> SilentFlowClient

type [<AllowNullLiteral>] SilentFlowRequest =
    inherit BaseAuthRequest
    abstract account: AccountInfo option with get, set
    abstract forceRefresh: bool option with get, set

type [<AllowNullLiteral>] SilentRequest =
    inherit SilentFlowRequest
    abstract redirectUri: string option with get, set

type [<AllowNullLiteral>] SsoSilentRequest =
    inherit AuthorizationUrlRequest

type [<AllowNullLiteral>] StringDict =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] SystemOptions =
    abstract tokenRenewalOffsetSeconds: float option with get, set

type [<AllowNullLiteral>] TokenClaims =
    abstract iss: string option with get, set
    abstract oid: string option with get, set
    abstract sub: string option with get, set
    abstract tid: string option with get, set
    abstract ver: string option with get, set
    abstract upn: string option with get, set
    abstract preferred_username: string option with get, set
    abstract emails: ResizeArray<string> option with get, set
    abstract name: string option with get, set
    abstract nonce: string option with get, set
    abstract exp: float option with get, set
    abstract home_oid: string option with get, set
    abstract sid: string option with get, set
    abstract cloud_instance_host_name: string option with get, set
    abstract cnf: TokenClaimsCnf option with get, set

type [<AllowNullLiteral>] AuthErrorMessageUnexpectedError =
    abstract code: string with get, set
    abstract desc: string with get, set

type [<AllowNullLiteral>] AuthErrorMessage =
    abstract unexpectedError: AuthErrorMessageUnexpectedError with get, set

type [<AllowNullLiteral>] BrowserAuthErrorMessage =
    abstract pkceNotGenerated: AuthErrorMessageUnexpectedError with get, set
    abstract cryptoDoesNotExist: AuthErrorMessageUnexpectedError with get, set
    abstract httpMethodNotImplementedError: AuthErrorMessageUnexpectedError with get, set
    abstract emptyNavigateUriError: AuthErrorMessageUnexpectedError with get, set
    abstract hashEmptyError: AuthErrorMessageUnexpectedError with get, set
    abstract interactionInProgress: AuthErrorMessageUnexpectedError with get, set
    abstract popUpWindowError: AuthErrorMessageUnexpectedError with get, set
    abstract emptyWindowError: AuthErrorMessageUnexpectedError with get, set
    abstract userCancelledError: AuthErrorMessageUnexpectedError with get, set
    abstract monitorWindowTimeoutError: AuthErrorMessageUnexpectedError with get, set
    abstract redirectInIframeError: AuthErrorMessageUnexpectedError with get, set
    abstract blockTokenRequestsInHiddenIframeError: AuthErrorMessageUnexpectedError with get, set
    abstract iframeClosedPrematurelyError: AuthErrorMessageUnexpectedError with get, set
    abstract silentSSOInsufficientInfoError: AuthErrorMessageUnexpectedError with get, set
    abstract silentPromptValueError: AuthErrorMessageUnexpectedError with get, set
    abstract tokenRequestCacheError: AuthErrorMessageUnexpectedError with get, set
    abstract invalidCacheType: AuthErrorMessageUnexpectedError with get, set
    abstract notInBrowserEnvironment: AuthErrorMessageUnexpectedError with get, set

type [<AllowNullLiteral>] BrowserConfigurationAuthErrorMessage =
    abstract redirectUriNotSet: AuthErrorMessageUnexpectedError with get, set
    abstract postLogoutUriNotSet: AuthErrorMessageUnexpectedError with get, set
    abstract storageNotSupportedError: AuthErrorMessageUnexpectedError with get, set
    abstract noRedirectCallbacksSet: AuthErrorMessageUnexpectedError with get, set
    abstract invalidCallbackObject: AuthErrorMessageUnexpectedError with get, set

type [<AllowNullLiteral>] ClientCredentialsClientAssertion =
    abstract assertion: string with get, set
    abstract assertionType: string with get, set

type [<AllowNullLiteral>] TokenClaimsCnf =
    abstract kid: string with get, set
