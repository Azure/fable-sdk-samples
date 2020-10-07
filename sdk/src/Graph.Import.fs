// ts2fable 0.7.1
module rec Azure.Sdk.Graph
open System
open Fable.Core
open Fable.Core.JS
open MsRest

let [<Import("*","@azure/graph")>] exports: IExports = jsNative

let [<Import("AddOwnerParameters_2","@azure/graph")>] AddOwnerParameters_2: CompositeMapper = jsNative
let [<Import("ADGroup_2","@azure/graph")>] ADGroup_2: CompositeMapper = jsNative
let [<Import("Application_2","@azure/graph")>] Application_2: CompositeMapper = jsNative
let [<Import("ApplicationBase_2","@azure/graph")>] ApplicationBase_2: CompositeMapper = jsNative
let [<Import("ApplicationCreateParameters_2","@azure/graph")>] ApplicationCreateParameters_2: CompositeMapper = jsNative
let [<Import("ApplicationListResult_2","@azure/graph")>] ApplicationListResult_2: CompositeMapper = jsNative
let [<Import("ApplicationUpdateParameters_2","@azure/graph")>] ApplicationUpdateParameters_2: CompositeMapper = jsNative
let [<Import("AppRole_2","@azure/graph")>] AppRole_2: CompositeMapper = jsNative
let [<Import("BaseResource_2","@azure/graph")>] BaseResource_2: CompositeMapper = jsNative
let [<Import("CheckGroupMembershipParameters_2","@azure/graph")>] CheckGroupMembershipParameters_2: CompositeMapper = jsNative
let [<Import("CheckGroupMembershipResult_2","@azure/graph")>] CheckGroupMembershipResult_2: CompositeMapper = jsNative
let [<Import("CloudError_2","@azure/graph")>] CloudError_2: CompositeMapper = jsNative
let [<Import("DirectoryObject_2","@azure/graph")>] DirectoryObject_2: CompositeMapper = jsNative
let [<Import("DirectoryObjectListResult_2","@azure/graph")>] DirectoryObjectListResult_2: CompositeMapper = jsNative
let [<Import("discriminators","@azure/graph")>] discriminators: Discriminators = jsNative
let [<Import("Domain_2","@azure/graph")>] Domain_2: CompositeMapper = jsNative
let [<Import("DomainListResult_2","@azure/graph")>] DomainListResult_2: CompositeMapper = jsNative
let [<Import("GetObjectsParameters_2","@azure/graph")>] GetObjectsParameters_2: CompositeMapper = jsNative
let [<Import("GraphError_2","@azure/graph")>] GraphError_2: CompositeMapper = jsNative
let [<Import("GroupAddMemberParameters_2","@azure/graph")>] GroupAddMemberParameters_2: CompositeMapper = jsNative
let [<Import("GroupCreateParameters_2","@azure/graph")>] GroupCreateParameters_2: CompositeMapper = jsNative
let [<Import("GroupGetMemberGroupsParameters_2","@azure/graph")>] GroupGetMemberGroupsParameters_2: CompositeMapper = jsNative
let [<Import("GroupGetMemberGroupsResult_2","@azure/graph")>] GroupGetMemberGroupsResult_2: CompositeMapper = jsNative
let [<Import("GroupListResult_2","@azure/graph")>] GroupListResult_2: CompositeMapper = jsNative
let [<Import("InformationalUrl_2","@azure/graph")>] InformationalUrl_2: CompositeMapper = jsNative
let [<Import("KeyCredential_2","@azure/graph")>] KeyCredential_2: CompositeMapper = jsNative
let [<Import("KeyCredentialListResult_2","@azure/graph")>] KeyCredentialListResult_2: CompositeMapper = jsNative
let [<Import("KeyCredentialsUpdateParameters_2","@azure/graph")>] KeyCredentialsUpdateParameters_2: CompositeMapper = jsNative
let [<Import("OAuth2Permission_2","@azure/graph")>] OAuth2Permission_2: CompositeMapper = jsNative
let [<Import("OAuth2PermissionGrant_2","@azure/graph")>] OAuth2PermissionGrant_2: CompositeMapper = jsNative
let [<Import("OAuth2PermissionGrantListResult_2","@azure/graph")>] OAuth2PermissionGrantListResult_2: CompositeMapper = jsNative
let [<Import("OptionalClaim_2","@azure/graph")>] OptionalClaim_2: CompositeMapper = jsNative
let [<Import("OptionalClaims_2","@azure/graph")>] OptionalClaims_2: CompositeMapper = jsNative
let [<Import("PasswordCredential_2","@azure/graph")>] PasswordCredential_2: CompositeMapper = jsNative
let [<Import("PasswordCredentialListResult_2","@azure/graph")>] PasswordCredentialListResult_2: CompositeMapper = jsNative
let [<Import("PasswordCredentialsUpdateParameters_2","@azure/graph")>] PasswordCredentialsUpdateParameters_2: CompositeMapper = jsNative
let [<Import("PasswordProfile_2","@azure/graph")>] PasswordProfile_2: CompositeMapper = jsNative
let [<Import("PreAuthorizedApplication_2","@azure/graph")>] PreAuthorizedApplication_2: CompositeMapper = jsNative
let [<Import("PreAuthorizedApplicationExtension_2","@azure/graph")>] PreAuthorizedApplicationExtension_2: CompositeMapper = jsNative
let [<Import("PreAuthorizedApplicationPermission_2","@azure/graph")>] PreAuthorizedApplicationPermission_2: CompositeMapper = jsNative
let [<Import("RequiredResourceAccess_2","@azure/graph")>] RequiredResourceAccess_2: CompositeMapper = jsNative
let [<Import("ResourceAccess_2","@azure/graph")>] ResourceAccess_2: CompositeMapper = jsNative
let [<Import("ServicePrincipal_2","@azure/graph")>] ServicePrincipal_2: CompositeMapper = jsNative
let [<Import("ServicePrincipalBase_2","@azure/graph")>] ServicePrincipalBase_2: CompositeMapper = jsNative
let [<Import("ServicePrincipalCreateParameters_2","@azure/graph")>] ServicePrincipalCreateParameters_2: CompositeMapper = jsNative
let [<Import("ServicePrincipalListResult_2","@azure/graph")>] ServicePrincipalListResult_2: CompositeMapper = jsNative
let [<Import("ServicePrincipalObjectResult_2","@azure/graph")>] ServicePrincipalObjectResult_2: CompositeMapper = jsNative
let [<Import("ServicePrincipalUpdateParameters_2","@azure/graph")>] ServicePrincipalUpdateParameters_2: CompositeMapper = jsNative
let [<Import("SignInName_2","@azure/graph")>] SignInName_2: CompositeMapper = jsNative
let [<Import("User_2","@azure/graph")>] User_2: CompositeMapper = jsNative
let [<Import("UserBase_2","@azure/graph")>] UserBase_2: CompositeMapper = jsNative
let [<Import("UserCreateParameters_2","@azure/graph")>] UserCreateParameters_2: CompositeMapper = jsNative
let [<Import("UserGetMemberGroupsParameters_2","@azure/graph")>] UserGetMemberGroupsParameters_2: CompositeMapper = jsNative
let [<Import("UserGetMemberGroupsResult_2","@azure/graph")>] UserGetMemberGroupsResult_2: CompositeMapper = jsNative
let [<Import("UserListResult_2","@azure/graph")>] UserListResult_2: CompositeMapper = jsNative
let [<Import("UserUpdateParameters_2","@azure/graph")>] UserUpdateParameters_2: CompositeMapper = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Applications: ApplicationsStatic
    abstract DeletedApplications: DeletedApplicationsStatic
    abstract Domains: DomainsStatic
    abstract GraphRbacManagementClient: GraphRbacManagementClientStatic
    abstract GraphRbacManagementClientContext: GraphRbacManagementClientContextStatic
    abstract Groups: GroupsStatic
    abstract OAuth2PermissionGrantOperations: OAuth2PermissionGrantOperationsStatic
    abstract Objects: ObjectsStatic
    abstract ServicePrincipals: ServicePrincipalsStatic
    abstract SignedInUser: SignedInUserStatic
    abstract Users: UsersStatic

/// Request parameters for adding a owner to an application.
type [<AllowNullLiteral>] AddOwnerParameters =
    /// A owner object URL, such as
    /// "https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd",
    /// where "0b1f9851-1bf0-433f-aec3-cb9272f093dc" is the tenantId and
    /// "f260bbc4-c254-447b-94cf-293b5ec434dd" is the objectId of the owner (user, application,
    /// servicePrincipal, group) to be added.
    abstract url: string with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Active Directory group information.
type [<AllowNullLiteral>] ADGroup =
    /// Polymorphic Discriminator
    abstract objectType: string with get, set
    /// The object ID.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract objectId: string option
    /// The time at which the directory object was deleted.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract deletionTimestamp: DateTime option
    /// The display name of the group.
    abstract displayName: string option with get, set
    /// Whether the group is mail-enabled. Must be false. This is because only pure security groups
    /// can be created using the Graph API.
    abstract mailEnabled: bool option with get, set
    /// The mail alias for the group.
    abstract mailNickname: string option with get, set
    /// Whether the group is security-enable.
    abstract securityEnabled: bool option with get, set
    /// The primary email address of the group.
    abstract mail: string option with get, set

/// Active Directory application information.
type [<AllowNullLiteral>] Application =
    /// Polymorphic Discriminator
    abstract objectType: string with get, set
    /// The object ID.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract objectId: string option
    /// The time at which the directory object was deleted.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract deletionTimestamp: DateTime option
    /// The application ID.
    abstract appId: string option with get, set
    /// A property on the application to indicate if the application accepts other IDPs or not or
    /// partially accepts.
    abstract allowGuestsSignIn: bool option with get, set
    /// Indicates that the application supports pass through users who have no presence in the
    /// resource tenant.
    abstract allowPassthroughUsers: bool option with get, set
    /// The url for the application logo image stored in a CDN.
    abstract appLogoUrl: string option with get, set
    /// The collection of application roles that an application may declare. These roles can be
    /// assigned to users, groups or service principals.
    abstract appRoles: ResizeArray<AppRole> option with get, set
    /// The application permissions.
    abstract appPermissions: ResizeArray<string> option with get, set
    /// Whether the application is available to other tenants.
    abstract availableToOtherTenants: bool option with get, set
    /// The display name of the application.
    abstract displayName: string option with get, set
    /// A URL provided by the author of the application to report errors when using the application.
    abstract errorUrl: string option with get, set
    /// Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects.
    abstract groupMembershipClaims: obj option with get, set
    /// The home page of the application.
    abstract homepage: string option with get, set
    /// A collection of URIs for the application.
    abstract identifierUris: ResizeArray<string> option with get, set
    /// URLs with more information about the application.
    abstract informationalUrls: InformationalUrl option with get, set
    /// Specifies whether this application supports device authentication without a user. The default
    /// is false.
    abstract isDeviceOnlyAuthSupported: bool option with get, set
    /// A collection of KeyCredential objects.
    abstract keyCredentials: ResizeArray<KeyCredential> option with get, set
    /// Client applications that are tied to this resource application. Consent to any of the known
    /// client applications will result in implicit consent to the resource application through a
    /// combined consent dialog (showing the OAuth permission scopes required by the client and the
    /// resource).
    abstract knownClientApplications: ResizeArray<string> option with get, set
    /// the url of the logout page
    abstract logoutUrl: string option with get, set
    /// Whether to allow implicit grant flow for OAuth2
    abstract oauth2AllowImplicitFlow: bool option with get, set
    /// Specifies whether during a token Request Azure AD will allow path matching of the redirect URI
    /// against the applications collection of replyURLs. The default is false.
    abstract oauth2AllowUrlPathMatching: bool option with get, set
    /// The collection of OAuth 2.0 permission scopes that the web API (resource) application exposes
    /// to client applications. These permission scopes may be granted to client applications during
    /// consent.
    abstract oauth2Permissions: ResizeArray<OAuth2Permission> option with get, set
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD will allow POST requests, as
    /// opposed to GET requests. The default is false, which specifies that only GET requests will be
    /// allowed.
    abstract oauth2RequirePostResponse: bool option with get, set
    /// A list of tenants allowed to access application.
    abstract orgRestrictions: ResizeArray<string> option with get, set
    abstract optionalClaims: OptionalClaims option with get, set
    /// A collection of PasswordCredential objects
    abstract passwordCredentials: ResizeArray<PasswordCredential> option with get, set
    /// list of pre-authorized applications.
    abstract preAuthorizedApplications: ResizeArray<PreAuthorizedApplication> option with get, set
    /// Specifies whether this application is a public client (such as an installed application
    /// running on a mobile device). Default is false.
    abstract publicClient: bool option with get, set
    /// Reliable domain which can be used to identify an application.
    abstract publisherDomain: string option with get, set
    /// A collection of reply URLs for the application.
    abstract replyUrls: ResizeArray<string> option with get, set
    /// Specifies resources that this application requires access to and the set of OAuth permission
    /// scopes and application roles that it needs under each of those resources. This
    /// pre-configuration of required resource access drives the consent experience.
    abstract requiredResourceAccess: ResizeArray<RequiredResourceAccess> option with get, set
    /// The URL to the SAML metadata for the application.
    abstract samlMetadataUrl: string option with get, set
    /// Audience for signing in to the application (AzureADMyOrganization, AzureADAllOrganizations,
    /// AzureADAndMicrosoftAccounts).
    abstract signInAudience: string option with get, set
    /// The primary Web page.
    abstract wwwHomepage: string option with get, set

/// Active Directive Application common properties shared among GET, POST and PATCH
type [<AllowNullLiteral>] ApplicationBase =
    /// A property on the application to indicate if the application accepts other IDPs or not or
    /// partially accepts.
    abstract allowGuestsSignIn: bool option with get, set
    /// Indicates that the application supports pass through users who have no presence in the
    /// resource tenant.
    abstract allowPassthroughUsers: bool option with get, set
    /// The url for the application logo image stored in a CDN.
    abstract appLogoUrl: string option with get, set
    /// The collection of application roles that an application may declare. These roles can be
    /// assigned to users, groups or service principals.
    abstract appRoles: ResizeArray<AppRole> option with get, set
    /// The application permissions.
    abstract appPermissions: ResizeArray<string> option with get, set
    /// Whether the application is available to other tenants.
    abstract availableToOtherTenants: bool option with get, set
    /// A URL provided by the author of the application to report errors when using the application.
    abstract errorUrl: string option with get, set
    /// Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects.
    abstract groupMembershipClaims: obj option with get, set
    /// The home page of the application.
    abstract homepage: string option with get, set
    /// URLs with more information about the application.
    abstract informationalUrls: InformationalUrl option with get, set
    /// Specifies whether this application supports device authentication without a user. The default
    /// is false.
    abstract isDeviceOnlyAuthSupported: bool option with get, set
    /// A collection of KeyCredential objects.
    abstract keyCredentials: ResizeArray<KeyCredential> option with get, set
    /// Client applications that are tied to this resource application. Consent to any of the known
    /// client applications will result in implicit consent to the resource application through a
    /// combined consent dialog (showing the OAuth permission scopes required by the client and the
    /// resource).
    abstract knownClientApplications: ResizeArray<string> option with get, set
    /// the url of the logout page
    abstract logoutUrl: string option with get, set
    /// Whether to allow implicit grant flow for OAuth2
    abstract oauth2AllowImplicitFlow: bool option with get, set
    /// Specifies whether during a token Request Azure AD will allow path matching of the redirect URI
    /// against the applications collection of replyURLs. The default is false.
    abstract oauth2AllowUrlPathMatching: bool option with get, set
    /// The collection of OAuth 2.0 permission scopes that the web API (resource) application exposes
    /// to client applications. These permission scopes may be granted to client applications during
    /// consent.
    abstract oauth2Permissions: ResizeArray<OAuth2Permission> option with get, set
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD will allow POST requests, as
    /// opposed to GET requests. The default is false, which specifies that only GET requests will be
    /// allowed.
    abstract oauth2RequirePostResponse: bool option with get, set
    /// A list of tenants allowed to access application.
    abstract orgRestrictions: ResizeArray<string> option with get, set
    abstract optionalClaims: OptionalClaims option with get, set
    /// A collection of PasswordCredential objects
    abstract passwordCredentials: ResizeArray<PasswordCredential> option with get, set
    /// list of pre-authorized applications.
    abstract preAuthorizedApplications: ResizeArray<PreAuthorizedApplication> option with get, set
    /// Specifies whether this application is a public client (such as an installed application
    /// running on a mobile device). Default is false.
    abstract publicClient: bool option with get, set
    /// Reliable domain which can be used to identify an application.
    abstract publisherDomain: string option with get, set
    /// A collection of reply URLs for the application.
    abstract replyUrls: ResizeArray<string> option with get, set
    /// Specifies resources that this application requires access to and the set of OAuth permission
    /// scopes and application roles that it needs under each of those resources. This
    /// pre-configuration of required resource access drives the consent experience.
    abstract requiredResourceAccess: ResizeArray<RequiredResourceAccess> option with get, set
    /// The URL to the SAML metadata for the application.
    abstract samlMetadataUrl: string option with get, set
    /// Audience for signing in to the application (AzureADMyOrganization, AzureADAllOrganizations,
    /// AzureADAndMicrosoftAccounts).
    abstract signInAudience: string option with get, set
    /// The primary Web page.
    abstract wwwHomepage: string option with get, set

/// Request parameters for creating a new application.
type [<AllowNullLiteral>] ApplicationCreateParameters =
    inherit ApplicationBase
    /// The display name of the application.
    abstract displayName: string with get, set
    /// A collection of URIs for the application.
    abstract identifierUris: ResizeArray<string> option with get, set

type [<AllowNullLiteral>] ApplicationListResult =
    inherit Array<Application>
    /// The URL to get the next set of results.
    abstract odatanextLink: string option with get, set

/// Class representing a Applications.
type [<AllowNullLiteral>] Applications =
    /// <summary>Create a new application.</summary>
    /// <param name="parameters">The parameters for creating an application.</param>
    /// <param name="options">The optional parameters</param>
    abstract create: parameters: ApplicationCreateParameters * ?options: RequestOptionsBase -> Promise<ApplicationsCreateResponse>
    /// <param name="parameters">The parameters for creating an application.</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: ApplicationCreateParameters * callback: ServiceCallback<Application> -> unit
    /// <param name="parameters">The parameters for creating an application.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: ApplicationCreateParameters * options: RequestOptionsBase * callback: ServiceCallback<Application> -> unit
    /// <summary>Lists applications by filter parameters.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: ApplicationsListOptionalParams -> Promise<ApplicationsListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<ApplicationListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: ApplicationsListOptionalParams * callback: ServiceCallback<ApplicationListResult> -> unit
    /// <summary>Delete an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract deleteMethod: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: applicationObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Get an application by object ID.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract get: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<ApplicationsGetResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract get: applicationObjectId: string * callback: ServiceCallback<Application> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<Application> -> unit
    /// <summary>Update an existing application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="parameters">Parameters to update an existing application.</param>
    /// <param name="options">The optional parameters</param>
    abstract patch: applicationObjectId: string * parameters: ApplicationUpdateParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="parameters">Parameters to update an existing application.</param>
    /// <param name="callback">The callback</param>
    abstract patch: applicationObjectId: string * parameters: ApplicationUpdateParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="parameters">Parameters to update an existing application.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract patch: applicationObjectId: string * parameters: ApplicationUpdateParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="applicationObjectId">The object ID of the application for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwners: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<ApplicationsListOwnersResponse>
    /// <param name="applicationObjectId">The object ID of the application for which to get owners.</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: applicationObjectId: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="applicationObjectId">The object ID of the application for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Add an owner to an application.</summary>
    /// <param name="applicationObjectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    abstract addOwner: applicationObjectId: string * parameters: AddOwnerParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="callback">The callback</param>
    abstract addOwner: applicationObjectId: string * parameters: AddOwnerParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract addOwner: applicationObjectId: string * parameters: AddOwnerParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Remove a member from owners.</summary>
    /// <param name="applicationObjectId">The object ID of the application from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="options">The optional parameters</param>
    abstract removeOwner: applicationObjectId: string * ownerObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">The object ID of the application from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="callback">The callback</param>
    abstract removeOwner: applicationObjectId: string * ownerObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">The object ID of the application from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract removeOwner: applicationObjectId: string * ownerObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Get the keyCredentials associated with an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract listKeyCredentials: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<ApplicationsListKeyCredentialsResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract listKeyCredentials: applicationObjectId: string * callback: ServiceCallback<KeyCredentialListResult> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listKeyCredentials: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<KeyCredentialListResult> -> unit
    /// <summary>Update the keyCredentials associated with an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    abstract updateKeyCredentials: applicationObjectId: string * value: ResizeArray<KeyCredential> * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="callback">The callback</param>
    abstract updateKeyCredentials: applicationObjectId: string * value: ResizeArray<KeyCredential> * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract updateKeyCredentials: applicationObjectId: string * value: ResizeArray<KeyCredential> * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Get the passwordCredentials associated with an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract listPasswordCredentials: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<ApplicationsListPasswordCredentialsResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract listPasswordCredentials: applicationObjectId: string * callback: ServiceCallback<PasswordCredentialListResult> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listPasswordCredentials: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<PasswordCredentialListResult> -> unit
    /// <summary>Update passwordCredentials associated with an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="options">The optional parameters</param>
    abstract updatePasswordCredentials: applicationObjectId: string * value: ResizeArray<PasswordCredential> * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="callback">The callback</param>
    abstract updatePasswordCredentials: applicationObjectId: string * value: ResizeArray<PasswordCredential> * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract updatePasswordCredentials: applicationObjectId: string * value: ResizeArray<PasswordCredential> * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets an object id for a given application id from the current tenant.</summary>
    /// <param name="applicationID">The application ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract getServicePrincipalsIdByAppId: applicationID: string * ?options: RequestOptionsBase -> Promise<ApplicationsGetServicePrincipalsIdByAppIdResponse>
    /// <param name="applicationID">The application ID.</param>
    /// <param name="callback">The callback</param>
    abstract getServicePrincipalsIdByAppId: applicationID: string * callback: ServiceCallback<ServicePrincipalObjectResult> -> unit
    /// <param name="applicationID">The application ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getServicePrincipalsIdByAppId: applicationID: string * options: RequestOptionsBase * callback: ServiceCallback<ServicePrincipalObjectResult> -> unit
    /// <summary>Gets a list of applications from the current tenant.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<ApplicationsListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<ApplicationListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<ApplicationListResult> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwnersNext: nextPageLink: string * ?options: RequestOptionsBase -> Promise<ApplicationsListOwnersNextResponse>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit

/// Class representing a Applications.
type [<AllowNullLiteral>] ApplicationsStatic =
    /// <summary>Create a Applications.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> Applications

type [<AllowNullLiteral>] ApplicationsCreateResponse =
    inherit Application
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsGetResponse =
    inherit Application
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsGetServicePrincipalsIdByAppIdResponse =
    inherit ServicePrincipalObjectResult
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsListKeyCredentialsResponse =
    inherit KeyCredentialListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsListNextResponse =
    inherit ApplicationListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] ApplicationsListOptionalParams =
    inherit RequestOptionsBase
    /// The filters to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] ApplicationsListOwnersNextResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsListOwnersResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsListPasswordCredentialsResponse =
    inherit PasswordCredentialListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ApplicationsListResponse =
    inherit ApplicationListResult
    inherit HttpResponse

/// Request parameters for updating a new application.
type [<AllowNullLiteral>] ApplicationUpdateParameters =
    inherit ApplicationBase
    /// The display name of the application.
    abstract displayName: string option with get, set
    /// A collection of URIs for the application.
    abstract identifierUris: ResizeArray<string> option with get, set

/// An interface representing AppRole.
type [<AllowNullLiteral>] AppRole =
    /// Unique role identifier inside the appRoles collection.
    abstract id: string option with get, set
    /// Specifies whether this app role definition can be assigned to users and groups by setting to
    /// 'User', or to other applications (that are accessing this application in daemon service
    /// scenarios) by setting to 'Application', or to both.
    abstract allowedMemberTypes: ResizeArray<string> option with get, set
    /// Permission help text that appears in the admin app assignment and consent experiences.
    abstract description: string option with get, set
    /// Display name for the permission that appears in the admin consent and app assignment
    /// experiences.
    abstract displayName: string option with get, set
    /// When creating or updating a role definition, this must be set to true (which is the default).
    /// To delete a role, this must first be set to false. At that point, in a subsequent call, this
    /// role may be removed.
    abstract isEnabled: bool option with get, set
    /// Specifies the value of the roles claim that the application should expect in the
    /// authentication and access tokens.
    abstract value: string option with get, set

/// Request parameters for IsMemberOf API call.
type [<AllowNullLiteral>] CheckGroupMembershipParameters =
    /// The object ID of the group to check.
    abstract groupId: string with get, set
    /// The object ID of the contact, group, user, or service principal to check for membership in the
    /// specified group.
    abstract memberId: string with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Server response for IsMemberOf API call
type [<AllowNullLiteral>] CheckGroupMembershipResult =
    /// True if the specified user, group, contact, or service principal has either direct or
    /// transitive membership in the specified group; otherwise, false.
    abstract value: bool option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ConsentType =
    | [<CompiledName "AllPrincipals">] AllPrincipals
    | [<CompiledName "Principal">] Principal

/// Class representing a DeletedApplications.
type [<AllowNullLiteral>] DeletedApplications =
    /// <summary>Restores the deleted application in the directory.</summary>
    /// <param name="objectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract restore: objectId: string * ?options: RequestOptionsBase -> Promise<DeletedApplicationsRestoreResponse>
    /// <param name="objectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract restore: objectId: string * callback: ServiceCallback<Application> -> unit
    /// <param name="objectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract restore: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<Application> -> unit
    /// <summary>Gets a list of deleted applications in the directory.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: DeletedApplicationsListOptionalParams -> Promise<DeletedApplicationsListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<ApplicationListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: DeletedApplicationsListOptionalParams * callback: ServiceCallback<ApplicationListResult> -> unit
    /// <summary>Hard-delete an application.</summary>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    abstract hardDelete: applicationObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="callback">The callback</param>
    abstract hardDelete: applicationObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="applicationObjectId">Application object ID.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract hardDelete: applicationObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets a list of deleted applications in the directory.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<DeletedApplicationsListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<ApplicationListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<ApplicationListResult> -> unit

/// Class representing a DeletedApplications.
type [<AllowNullLiteral>] DeletedApplicationsStatic =
    /// <summary>Create a DeletedApplications.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> DeletedApplications

type [<AllowNullLiteral>] DeletedApplicationsListNextResponse =
    inherit ApplicationListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] DeletedApplicationsListOptionalParams =
    inherit RequestOptionsBase
    /// The filter to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] DeletedApplicationsListResponse =
    inherit ApplicationListResult
    inherit HttpResponse

type [<AllowNullLiteral>] DeletedApplicationsRestoreResponse =
    inherit Application
    inherit HttpResponse

/// Represents an Azure Active Directory object.
type [<AllowNullLiteral>] DirectoryObject =
    /// Polymorphic Discriminator
    abstract objectType: string with get, set
    /// The object ID.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract objectId: string option
    /// The time at which the directory object was deleted.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract deletionTimestamp: DateTime option
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] DirectoryObjectListResult =
    inherit Array<DirectoryObjectUnion>
    /// The URL to get the next set of results.
    abstract odatanextLink: string option with get, set

type DirectoryObjectUnion =
    U5<DirectoryObject, Application, ADGroup, ServicePrincipal, User>

/// Active Directory Domain information.
type [<AllowNullLiteral>] Domain =
    /// the type of the authentication into the domain.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract authenticationType: string option
    /// if this is the default domain in the tenant.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract isDefault: bool option
    /// if this domain's ownership is verified.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract isVerified: bool option
    /// the domain name.
    abstract name: string with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] DomainListResult =
    inherit Array<Domain>

/// Class representing a Domains.
type [<AllowNullLiteral>] Domains =
    /// <summary>Gets a list of domains for the current tenant.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: DomainsListOptionalParams -> Promise<DomainsListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<DomainListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: DomainsListOptionalParams * callback: ServiceCallback<DomainListResult> -> unit
    /// <summary>Gets a specific domain in the current tenant.</summary>
    /// <param name="domainName">name of the domain.</param>
    /// <param name="options">The optional parameters</param>
    abstract get: domainName: string * ?options: RequestOptionsBase -> Promise<DomainsGetResponse>
    /// <param name="domainName">name of the domain.</param>
    /// <param name="callback">The callback</param>
    abstract get: domainName: string * callback: ServiceCallback<Domain> -> unit
    /// <param name="domainName">name of the domain.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: domainName: string * options: RequestOptionsBase * callback: ServiceCallback<Domain> -> unit

/// Class representing a Domains.
type [<AllowNullLiteral>] DomainsStatic =
    /// <summary>Create a Domains.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> Domains

type [<AllowNullLiteral>] DomainsGetResponse =
    inherit Domain
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] DomainsListOptionalParams =
    inherit RequestOptionsBase
    /// The filter to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] DomainsListResponse =
    inherit DomainListResult
    inherit HttpResponse

/// Request parameters for the GetObjectsByObjectIds API.
type [<AllowNullLiteral>] GetObjectsParameters =
    /// The requested object IDs.
    abstract objectIds: ResizeArray<string> option with get, set
    /// The requested object types.
    abstract types: ResizeArray<string> option with get, set
    /// If true, also searches for object IDs in the partner tenant.
    abstract includeDirectoryObjectReferences: bool option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Active Directory error information.
type [<AllowNullLiteral>] GraphError =
    /// Error code.
    abstract code: string option with get, set
    /// Error message value.
    abstract message: string option with get, set

type [<AllowNullLiteral>] GraphRbacManagementClient =
    inherit GraphRbacManagementClientContext
    abstract signedInUser: SignedInUser with get, set
    abstract applications: Applications with get, set
    abstract deletedApplications: DeletedApplications with get, set
    abstract groups: Groups with get, set
    abstract servicePrincipals: ServicePrincipals with get, set
    abstract users: Users with get, set
    abstract objects: Objects with get, set
    abstract domains: Domains with get, set
    abstract oAuth2PermissionGrant: OAuth2PermissionGrantOperations with get, set

type [<AllowNullLiteral>] GraphRbacManagementClientStatic =
    /// <summary>Initializes a new instance of the GraphRbacManagementClient class.</summary>
    /// <param name="credentials">Credentials needed for the client to connect to Azure.</param>
    /// <param name="tenantID">The tenant ID.</param>
    /// <param name="options">The parameter options</param>
    [<Emit "new $0($1...)">] abstract Create: credentials: ServiceClientCredentials * tenantID: string * ?options: GraphRbacManagementClientOptions -> GraphRbacManagementClient

type [<AllowNullLiteral>] GraphRbacManagementClientContext =
    inherit AzureServiceClient
    abstract credentials: ServiceClientCredentials with get, set
    abstract apiVersion: string option with get, set
    abstract tenantID: string with get, set

type [<AllowNullLiteral>] GraphRbacManagementClientContextStatic =
    /// <summary>Initializes a new instance of the GraphRbacManagementClient class.</summary>
    /// <param name="credentials">Credentials needed for the client to connect to Azure.</param>
    /// <param name="tenantID">The tenant ID.</param>
    /// <param name="options">The parameter options</param>
    [<Emit "new $0($1...)">] abstract Create: credentials: ServiceClientCredentials * tenantID: string * ?options: GraphRbacManagementClientOptions -> GraphRbacManagementClientContext

/// An interface representing GraphRbacManagementClientOptions.
type [<AllowNullLiteral>] GraphRbacManagementClientOptions =
    inherit AzureServiceClientOptions
    abstract baseUri: string option with get, set

/// Request parameters for adding a member to a group.
type [<AllowNullLiteral>] GroupAddMemberParameters =
    /// A member object URL, such as
    /// "https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd",
    /// where "0b1f9851-1bf0-433f-aec3-cb9272f093dc" is the tenantId and
    /// "f260bbc4-c254-447b-94cf-293b5ec434dd" is the objectId of the member (user, application,
    /// servicePrincipal, group) to be added.
    abstract url: string with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Request parameters for creating a new group.
type [<AllowNullLiteral>] GroupCreateParameters =
    /// Group display name
    abstract displayName: string with get, set
    /// Mail nickname
    abstract mailNickname: string with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Request parameters for GetMemberGroups API call.
type [<AllowNullLiteral>] GroupGetMemberGroupsParameters =
    /// If true, only membership in security-enabled groups should be checked. Otherwise, membership
    /// in all groups should be checked.
    abstract securityEnabledOnly: bool with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] GroupGetMemberGroupsResult =
    inherit Array<string>

type [<AllowNullLiteral>] GroupListResult =
    inherit Array<ADGroup>
    /// The URL to get the next set of results.
    abstract odatanextLink: string option with get, set

/// Class representing a Groups.
type [<AllowNullLiteral>] Groups =
    /// <summary>Checks whether the specified user, group, contact, or service principal is a direct or
    /// transitive member of the specified group.</summary>
    /// <param name="parameters">The check group membership parameters.</param>
    /// <param name="options">The optional parameters</param>
    abstract isMemberOf: parameters: CheckGroupMembershipParameters * ?options: RequestOptionsBase -> Promise<GroupsIsMemberOfResponse>
    /// <param name="parameters">The check group membership parameters.</param>
    /// <param name="callback">The callback</param>
    abstract isMemberOf: parameters: CheckGroupMembershipParameters * callback: ServiceCallback<CheckGroupMembershipResult> -> unit
    /// <param name="parameters">The check group membership parameters.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract isMemberOf: parameters: CheckGroupMembershipParameters * options: RequestOptionsBase * callback: ServiceCallback<CheckGroupMembershipResult> -> unit
    /// <summary>Remove a member from a group.</summary>
    /// <param name="groupObjectId">The object ID of the group from which to remove the member.</param>
    /// <param name="memberObjectId">Member object id</param>
    /// <param name="options">The optional parameters</param>
    abstract removeMember: groupObjectId: string * memberObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="groupObjectId">The object ID of the group from which to remove the member.</param>
    /// <param name="memberObjectId">Member object id</param>
    /// <param name="callback">The callback</param>
    abstract removeMember: groupObjectId: string * memberObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="groupObjectId">The object ID of the group from which to remove the member.</param>
    /// <param name="memberObjectId">Member object id</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract removeMember: groupObjectId: string * memberObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Add a member to a group.</summary>
    /// <param name="groupObjectId">The object ID of the group to which to add the member.</param>
    /// <param name="parameters">The URL of the member object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    abstract addMember: groupObjectId: string * parameters: GroupAddMemberParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="groupObjectId">The object ID of the group to which to add the member.</param>
    /// <param name="parameters">The URL of the member object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="callback">The callback</param>
    abstract addMember: groupObjectId: string * parameters: GroupAddMemberParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="groupObjectId">The object ID of the group to which to add the member.</param>
    /// <param name="parameters">The URL of the member object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract addMember: groupObjectId: string * parameters: GroupAddMemberParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Create a group in the directory.</summary>
    /// <param name="parameters">The parameters for the group to create.</param>
    /// <param name="options">The optional parameters</param>
    abstract create: parameters: GroupCreateParameters * ?options: RequestOptionsBase -> Promise<GroupsCreateResponse>
    /// <param name="parameters">The parameters for the group to create.</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: GroupCreateParameters * callback: ServiceCallback<ADGroup> -> unit
    /// <param name="parameters">The parameters for the group to create.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: GroupCreateParameters * options: RequestOptionsBase * callback: ServiceCallback<ADGroup> -> unit
    /// <summary>Gets list of groups for the current tenant.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: GroupsListOptionalParams -> Promise<GroupsListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<GroupListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: GroupsListOptionalParams * callback: ServiceCallback<GroupListResult> -> unit
    /// <summary>Gets the members of a group.</summary>
    /// <param name="objectId">The object ID of the group whose members should be retrieved.</param>
    /// <param name="options">The optional parameters</param>
    abstract getGroupMembers: objectId: string * ?options: RequestOptionsBase -> Promise<GroupsGetGroupMembersResponse>
    /// <param name="objectId">The object ID of the group whose members should be retrieved.</param>
    /// <param name="callback">The callback</param>
    abstract getGroupMembers: objectId: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="objectId">The object ID of the group whose members should be retrieved.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getGroupMembers: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Gets group information from the directory.</summary>
    /// <param name="objectId">The object ID of the user for which to get group information.</param>
    /// <param name="options">The optional parameters</param>
    abstract get: objectId: string * ?options: RequestOptionsBase -> Promise<GroupsGetResponse>
    /// <param name="objectId">The object ID of the user for which to get group information.</param>
    /// <param name="callback">The callback</param>
    abstract get: objectId: string * callback: ServiceCallback<ADGroup> -> unit
    /// <param name="objectId">The object ID of the user for which to get group information.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<ADGroup> -> unit
    /// <summary>Delete a group from the directory.</summary>
    /// <param name="objectId">The object ID of the group to delete.</param>
    /// <param name="options">The optional parameters</param>
    abstract deleteMethod: objectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the group to delete.</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the group to delete.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets a collection of object IDs of groups of which the specified group is a member.</summary>
    /// <param name="objectId">The object ID of the group for which to get group membership.</param>
    /// <param name="parameters">Group filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    abstract getMemberGroups: objectId: string * parameters: GroupGetMemberGroupsParameters * ?options: RequestOptionsBase -> Promise<GroupsGetMemberGroupsResponse>
    /// <param name="objectId">The object ID of the group for which to get group membership.</param>
    /// <param name="parameters">Group filtering parameters.</param>
    /// <param name="callback">The callback</param>
    abstract getMemberGroups: objectId: string * parameters: GroupGetMemberGroupsParameters * callback: ServiceCallback<GroupGetMemberGroupsResult> -> unit
    /// <param name="objectId">The object ID of the group for which to get group membership.</param>
    /// <param name="parameters">Group filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getMemberGroups: objectId: string * parameters: GroupGetMemberGroupsParameters * options: RequestOptionsBase * callback: ServiceCallback<GroupGetMemberGroupsResult> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="objectId">The object ID of the group for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwners: objectId: string * ?options: RequestOptionsBase -> Promise<GroupsListOwnersResponse>
    /// <param name="objectId">The object ID of the group for which to get owners.</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: objectId: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="objectId">The object ID of the group for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Add an owner to a group.</summary>
    /// <param name="objectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    abstract addOwner: objectId: string * parameters: AddOwnerParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="callback">The callback</param>
    abstract addOwner: objectId: string * parameters: AddOwnerParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the application to which to add the owner.</param>
    /// <param name="parameters">The URL of the owner object, such as
    /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract addOwner: objectId: string * parameters: AddOwnerParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Remove a member from owners.</summary>
    /// <param name="objectId">The object ID of the group from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="options">The optional parameters</param>
    abstract removeOwner: objectId: string * ownerObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the group from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="callback">The callback</param>
    abstract removeOwner: objectId: string * ownerObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the group from which to remove the owner.</param>
    /// <param name="ownerObjectId">Owner object id</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract removeOwner: objectId: string * ownerObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets a list of groups for the current tenant.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<GroupsListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<GroupListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<GroupListResult> -> unit
    /// <summary>Gets the members of a group.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract getGroupMembersNext: nextLink: string * ?options: RequestOptionsBase -> Promise<GroupsGetGroupMembersNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract getGroupMembersNext: nextLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getGroupMembersNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwnersNext: nextPageLink: string * ?options: RequestOptionsBase -> Promise<GroupsListOwnersNextResponse>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit

/// Class representing a Groups.
type [<AllowNullLiteral>] GroupsStatic =
    /// <summary>Create a Groups.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> Groups

type [<AllowNullLiteral>] GroupsCreateResponse =
    inherit ADGroup
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsGetGroupMembersNextResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsGetGroupMembersResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsGetMemberGroupsResponse =
    inherit GroupGetMemberGroupsResult
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsGetResponse =
    inherit ADGroup
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsIsMemberOfResponse =
    inherit CheckGroupMembershipResult
    inherit HttpResponse

type [<AllowNullLiteral>] GroupsListNextResponse =
    inherit GroupListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] GroupsListOptionalParams =
    inherit RequestOptionsBase
    /// The filter to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] GroupsListOwnersNextResponse =
    interface end

type [<AllowNullLiteral>] GroupsListOwnersResponse =
    interface end

type [<AllowNullLiteral>] GroupsListResponse =
    interface end

/// Represents a group of URIs that provide terms of service, marketing, support and privacy policy
/// information about an application. The default value for each string is null.
type [<AllowNullLiteral>] InformationalUrl =
    /// The terms of service URI
    abstract termsOfService: string option with get, set
    /// The marketing URI
    abstract marketing: string option with get, set
    /// The privacy policy URI
    abstract privacy: string option with get, set
    /// The support URI
    abstract support: string option with get, set

/// Active Directory Key Credential information.
type [<AllowNullLiteral>] KeyCredential =
    /// Start date.
    abstract startDate: DateTime option with get, set
    /// End date.
    abstract endDate: DateTime option with get, set
    /// Key value.
    abstract value: string option with get, set
    /// Key ID.
    abstract keyId: string option with get, set
    /// Usage. Acceptable values are 'Verify' and 'Sign'.
    abstract usage: string option with get, set
    /// Type. Acceptable values are 'AsymmetricX509Cert' and 'Symmetric'.
    abstract ``type``: string option with get, set
    /// Custom Key Identifier
    abstract customKeyIdentifier: string option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] KeyCredentialListResult =
    inherit Array<KeyCredential>

/// Request parameters for a KeyCredentials update operation
type [<AllowNullLiteral>] KeyCredentialsUpdateParameters =
    /// A collection of KeyCredentials.
    abstract value: ResizeArray<KeyCredential> with get, set

/// Represents an OAuth 2.0 delegated permission scope. The specified OAuth 2.0 delegated permission
/// scopes may be requested by client applications (through the requiredResourceAccess collection on
/// the Application object) when calling a resource application. The oauth2Permissions property of
/// the ServicePrincipal entity and of the Application entity is a collection of OAuth2Permission.
type [<AllowNullLiteral>] OAuth2Permission =
    /// Permission help text that appears in the admin consent and app assignment experiences.
    abstract adminConsentDescription: string option with get, set
    /// Display name for the permission that appears in the admin consent and app assignment
    /// experiences.
    abstract adminConsentDisplayName: string option with get, set
    /// Unique scope permission identifier inside the oauth2Permissions collection.
    abstract id: string option with get, set
    /// When creating or updating a permission, this property must be set to true (which is the
    /// default). To delete a permission, this property must first be set to false. At that point, in
    /// a subsequent call, the permission may be removed.
    abstract isEnabled: bool option with get, set
    /// Specifies whether this scope permission can be consented to by an end user, or whether it is a
    /// tenant-wide permission that must be consented to by a Company Administrator. Possible values
    /// are "User" or "Admin".
    abstract ``type``: string option with get, set
    /// Permission help text that appears in the end user consent experience.
    abstract userConsentDescription: string option with get, set
    /// Display name for the permission that appears in the end user consent experience.
    abstract userConsentDisplayName: string option with get, set
    /// The value of the scope claim that the resource application should expect in the OAuth 2.0
    /// access token.
    abstract value: string option with get, set

/// An interface representing OAuth2PermissionGrant.
type [<AllowNullLiteral>] OAuth2PermissionGrant =
    /// Microsoft.DirectoryServices.OAuth2PermissionGrant
    abstract odatatype: string option with get, set
    /// The id of the resource's service principal granted consent to impersonate the user when
    /// accessing the resource (represented by the resourceId property).
    abstract clientId: string option with get, set
    /// The id of the permission grant
    abstract objectId: string option with get, set
    /// Indicates if consent was provided by the administrator (on behalf of the organization) or by
    /// an individual. Possible values include: 'AllPrincipals', 'Principal'
    abstract consentType: ConsentType option with get, set
    /// When consent type is Principal, this property specifies the id of the user that granted
    /// consent and applies only for that user.
    abstract principalId: string option with get, set
    /// Object Id of the resource you want to grant
    abstract resourceId: string option with get, set
    /// Specifies the value of the scope claim that the resource application should expect in the
    /// OAuth 2.0 access token. For example, User.Read
    abstract scope: string option with get, set
    /// Start time for TTL
    abstract startTime: string option with get, set
    /// Expiry time for TTL
    abstract expiryTime: string option with get, set

/// Optional Parameters.
type [<AllowNullLiteral>] OAuth2PermissionGrantCreateOptionalParams =
    inherit RequestOptionsBase
    /// The relevant app Service Principal Object Id and the Service Principal Object Id you want to
    /// grant.
    abstract body: OAuth2PermissionGrant option with get, set

type [<AllowNullLiteral>] OAuth2PermissionGrantCreateResponse =
    interface end

type [<AllowNullLiteral>] OAuth2PermissionGrantListNextResponse =
    inherit OAuth2PermissionGrantListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] OAuth2PermissionGrantListOptionalParams =
    inherit RequestOptionsBase
    /// This is the Service Principal ObjectId associated with the app
    abstract filter: string option with get, set

type [<AllowNullLiteral>] OAuth2PermissionGrantListResponse =
    inherit OAuth2PermissionGrantListResult
    inherit HttpResponse

type [<AllowNullLiteral>] OAuth2PermissionGrantListResult =
    inherit Array<OAuth2PermissionGrant>
    /// the URL to get the next set of results.
    abstract odatanextLink: string option with get, set

/// Class representing a OAuth2PermissionGrant
type [<AllowNullLiteral>] OAuth2PermissionGrantOperations =
    /// <summary>Queries OAuth2 permissions grants for the relevant SP ObjectId of an app.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: OAuth2PermissionGrantListOptionalParams -> Promise<OAuth2PermissionGrantListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<OAuth2PermissionGrantListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: OAuth2PermissionGrantListOptionalParams * callback: ServiceCallback<OAuth2PermissionGrantListResult> -> unit
    /// <summary>Grants OAuth2 permissions for the relevant resource Ids of an app.</summary>
    /// <param name="options">The optional parameters</param>
    abstract create: ?options: OAuth2PermissionGrantCreateOptionalParams -> Promise<OAuth2PermissionGrantCreateResponse>
    /// <param name="callback">The callback</param>
    abstract create: callback: ServiceCallback<OAuth2PermissionGrant> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract create: options: OAuth2PermissionGrantCreateOptionalParams * callback: ServiceCallback<OAuth2PermissionGrant> -> unit
    /// <summary>Delete a OAuth2 permission grant for the relevant resource Ids of an app.</summary>
    /// <param name="objectId">The object ID of a permission grant.</param>
    /// <param name="options">The optional parameters</param>
    abstract deleteMethod: objectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of a permission grant.</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of a permission grant.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets the next page of OAuth2 permission grants</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<OAuth2PermissionGrantListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<OAuth2PermissionGrantListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<OAuth2PermissionGrantListResult> -> unit

/// Class representing a OAuth2PermissionGrant
type [<AllowNullLiteral>] OAuth2PermissionGrantOperationsStatic =
    /// <summary>Create a OAuth2PermissionGrant</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> OAuth2PermissionGrantOperations

/// Class representing a Objects.
type [<AllowNullLiteral>] Objects =
    /// <summary>Gets the directory objects specified in a list of object IDs. You can also specify which
    /// resource collections (users, groups, etc.) should be searched by specifying the optional types
    /// parameter.</summary>
    /// <param name="parameters">Objects filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    abstract getObjectsByObjectIds: parameters: GetObjectsParameters * ?options: RequestOptionsBase -> Promise<ObjectsGetObjectsByObjectIdsResponse>
    /// <param name="parameters">Objects filtering parameters.</param>
    /// <param name="callback">The callback</param>
    abstract getObjectsByObjectIds: parameters: GetObjectsParameters * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="parameters">Objects filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getObjectsByObjectIds: parameters: GetObjectsParameters * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Gets AD group membership for the specified AD object IDs.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract getObjectsByObjectIdsNext: nextLink: string * ?options: RequestOptionsBase -> Promise<ObjectsGetObjectsByObjectIdsNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract getObjectsByObjectIdsNext: nextLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getObjectsByObjectIdsNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit

/// Class representing a Objects.
type [<AllowNullLiteral>] ObjectsStatic =
    /// <summary>Create a Objects.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> Objects

type [<AllowNullLiteral>] ObjectsGetObjectsByObjectIdsNextResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ObjectsGetObjectsByObjectIdsResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

/// Specifying the claims to be included in a token.
type [<AllowNullLiteral>] OptionalClaim =
    /// Claim name.
    abstract name: string option with get, set
    /// Claim source.
    abstract source: string option with get, set
    /// Is this a required claim.
    abstract essential: bool option with get, set
    abstract additionalProperties: obj option with get, set

/// Specifying the claims to be included in the token.
type [<AllowNullLiteral>] OptionalClaims =
    /// Optional claims requested to be included in the id token.
    abstract idToken: ResizeArray<OptionalClaim> option with get, set
    /// Optional claims requested to be included in the access token.
    abstract accessToken: ResizeArray<OptionalClaim> option with get, set
    /// Optional claims requested to be included in the saml token.
    abstract samlToken: ResizeArray<OptionalClaim> option with get, set

/// Active Directory Password Credential information.
type [<AllowNullLiteral>] PasswordCredential =
    /// Start date.
    abstract startDate: DateTime option with get, set
    /// End date.
    abstract endDate: DateTime option with get, set
    /// Key ID.
    abstract keyId: string option with get, set
    /// Key value.
    abstract value: string option with get, set
    /// Custom Key Identifier
    abstract customKeyIdentifier: Uint8Array option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] PasswordCredentialListResult =
    inherit Array<PasswordCredential>

/// Request parameters for a PasswordCredentials update operation.
type [<AllowNullLiteral>] PasswordCredentialsUpdateParameters =
    /// A collection of PasswordCredentials.
    abstract value: ResizeArray<PasswordCredential> with get, set

/// The password profile associated with a user.
type [<AllowNullLiteral>] PasswordProfile =
    /// Password
    abstract password: string with get, set
    /// Whether to force a password change on next login.
    abstract forceChangePasswordNextLogin: bool option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Contains information about pre authorized client application.
type [<AllowNullLiteral>] PreAuthorizedApplication =
    /// Represents the application id.
    abstract appId: string option with get, set
    /// Collection of required app permissions/entitlements from the resource application.
    abstract permissions: ResizeArray<PreAuthorizedApplicationPermission> option with get, set
    /// Collection of extensions from the resource application.
    abstract extensions: ResizeArray<PreAuthorizedApplicationExtension> option with get, set

/// Representation of an app PreAuthorizedApplicationExtension required by a pre authorized client
/// app.
type [<AllowNullLiteral>] PreAuthorizedApplicationExtension =
    /// The extension's conditions.
    abstract conditions: ResizeArray<string> option with get, set

/// Contains information about the pre-authorized permissions.
type [<AllowNullLiteral>] PreAuthorizedApplicationPermission =
    /// Indicates whether the permission set is DirectAccess or impersonation.
    abstract directAccessGrant: bool option with get, set
    /// The list of permissions.
    abstract accessGrants: ResizeArray<string> option with get, set

/// Specifies the set of OAuth 2.0 permission scopes and app roles under the specified resource that
/// an application requires access to. The specified OAuth 2.0 permission scopes may be requested by
/// client applications (through the requiredResourceAccess collection) when calling a resource
/// application. The requiredResourceAccess property of the Application entity is a collection of
/// RequiredResourceAccess.
type [<AllowNullLiteral>] RequiredResourceAccess =
    /// The list of OAuth2.0 permission scopes and app roles that the application requires from the
    /// specified resource.
    abstract resourceAccess: ResizeArray<ResourceAccess> with get, set
    /// The unique identifier for the resource that the application requires access to. This should be
    /// equal to the appId declared on the target resource application.
    abstract resourceAppId: string option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Specifies an OAuth 2.0 permission scope or an app role that an application requires. The
/// resourceAccess property of the RequiredResourceAccess type is a collection of ResourceAccess.
type [<AllowNullLiteral>] ResourceAccess =
    /// The unique identifier for one of the OAuth2Permission or AppRole instances that the resource
    /// application exposes.
    abstract id: string with get, set
    /// Specifies whether the id property references an OAuth2Permission or an AppRole. Possible
    /// values are "scope" or "role".
    abstract ``type``: string option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Active Directory service principal information.
type [<AllowNullLiteral>] ServicePrincipal =
    /// Polymorphic Discriminator
    abstract objectType: string with get, set
    /// The object ID.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract objectId: string option
    /// The time at which the directory object was deleted.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract deletionTimestamp: DateTime option
    /// whether or not the service principal account is enabled
    abstract accountEnabled: bool option with get, set
    /// alternative names
    abstract alternativeNames: ResizeArray<string> option with get, set
    /// The display name exposed by the associated application.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract appDisplayName: string option
    /// The application ID.
    abstract appId: string option with get, set
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract appOwnerTenantId: string option
    /// Specifies whether an AppRoleAssignment to a user or group is required before Azure AD will
    /// issue a user or access token to the application.
    abstract appRoleAssignmentRequired: bool option with get, set
    /// The collection of application roles that an application may declare. These roles can be
    /// assigned to users, groups or service principals.
    abstract appRoles: ResizeArray<AppRole> option with get, set
    /// The display name of the service principal.
    abstract displayName: string option with get, set
    /// A URL provided by the author of the associated application to report errors when using the
    /// application.
    abstract errorUrl: string option with get, set
    /// The URL to the homepage of the associated application.
    abstract homepage: string option with get, set
    /// The collection of key credentials associated with the service principal.
    abstract keyCredentials: ResizeArray<KeyCredential> option with get, set
    /// A URL provided by the author of the associated application to logout
    abstract logoutUrl: string option with get, set
    /// The OAuth 2.0 permissions exposed by the associated application.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract oauth2Permissions: ResizeArray<OAuth2Permission> option
    /// The collection of password credentials associated with the service principal.
    abstract passwordCredentials: ResizeArray<PasswordCredential> option with get, set
    /// The thumbprint of preferred certificate to sign the token
    abstract preferredTokenSigningKeyThumbprint: string option with get, set
    /// The publisher's name of the associated application
    abstract publisherName: string option with get, set
    /// The URLs that user tokens are sent to for sign in with the associated application.  The
    /// redirect URIs that the oAuth 2.0 authorization code and access tokens are sent to for the
    /// associated application.
    abstract replyUrls: ResizeArray<string> option with get, set
    /// The URL to the SAML metadata of the associated application
    abstract samlMetadataUrl: string option with get, set
    /// A collection of service principal names.
    abstract servicePrincipalNames: ResizeArray<string> option with get, set
    /// the type of the service principal
    abstract servicePrincipalType: string option with get, set
    /// Optional list of tags that you can apply to your service principals. Not nullable.
    abstract tags: ResizeArray<string> option with get, set

/// Active Directory service principal common properties shared among GET, POST and PATCH
type [<AllowNullLiteral>] ServicePrincipalBase =
    /// whether or not the service principal account is enabled
    abstract accountEnabled: bool option with get, set
    /// Specifies whether an AppRoleAssignment to a user or group is required before Azure AD will
    /// issue a user or access token to the application.
    abstract appRoleAssignmentRequired: bool option with get, set
    /// The collection of key credentials associated with the service principal.
    abstract keyCredentials: ResizeArray<KeyCredential> option with get, set
    /// The collection of password credentials associated with the service principal.
    abstract passwordCredentials: ResizeArray<PasswordCredential> option with get, set
    /// the type of the service principal
    abstract servicePrincipalType: string option with get, set
    /// Optional list of tags that you can apply to your service principals. Not nullable.
    abstract tags: ResizeArray<string> option with get, set

/// Request parameters for creating a new service principal.
type [<AllowNullLiteral>] ServicePrincipalCreateParameters =
    inherit ServicePrincipalBase
    /// The application ID.
    abstract appId: string with get, set

type [<AllowNullLiteral>] ServicePrincipalListResult =
    inherit Array<ServicePrincipal>
    /// the URL to get the next set of results.
    abstract odatanextLink: string option with get, set

/// Service Principal Object Result.
type [<AllowNullLiteral>] ServicePrincipalObjectResult =
    /// The Object ID of the service principal with the specified application ID.
    abstract value: string option with get, set
    /// The URL representing edm equivalent.
    abstract odatametadata: string option with get, set

/// Class representing a ServicePrincipals.
type [<AllowNullLiteral>] ServicePrincipals =
    /// <summary>Creates a service principal in the directory.</summary>
    /// <param name="parameters">Parameters to create a service principal.</param>
    /// <param name="options">The optional parameters</param>
    abstract create: parameters: ServicePrincipalCreateParameters * ?options: RequestOptionsBase -> Promise<ServicePrincipalsCreateResponse>
    /// <param name="parameters">Parameters to create a service principal.</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: ServicePrincipalCreateParameters * callback: ServiceCallback<ServicePrincipal> -> unit
    /// <param name="parameters">Parameters to create a service principal.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: ServicePrincipalCreateParameters * options: RequestOptionsBase * callback: ServiceCallback<ServicePrincipal> -> unit
    /// <summary>Gets a list of service principals from the current tenant.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: ServicePrincipalsListOptionalParams -> Promise<ServicePrincipalsListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<ServicePrincipalListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: ServicePrincipalsListOptionalParams * callback: ServiceCallback<ServicePrincipalListResult> -> unit
    /// <summary>Updates a service principal in the directory.</summary>
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="parameters">Parameters to update a service principal.</param>
    /// <param name="options">The optional parameters</param>
    abstract update: objectId: string * parameters: ServicePrincipalUpdateParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="parameters">Parameters to update a service principal.</param>
    /// <param name="callback">The callback</param>
    abstract update: objectId: string * parameters: ServicePrincipalUpdateParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="parameters">Parameters to update a service principal.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract update: objectId: string * parameters: ServicePrincipalUpdateParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Deletes a service principal from the directory.</summary>
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="options">The optional parameters</param>
    abstract deleteMethod: objectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the service principal to delete.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets service principal information from the directory. Query by objectId or pass a filter to
    /// query by appId</summary>
    /// <param name="objectId">The object ID of the service principal to get.</param>
    /// <param name="options">The optional parameters</param>
    abstract get: objectId: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsGetResponse>
    /// <param name="objectId">The object ID of the service principal to get.</param>
    /// <param name="callback">The callback</param>
    abstract get: objectId: string * callback: ServiceCallback<ServicePrincipal> -> unit
    /// <param name="objectId">The object ID of the service principal to get.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<ServicePrincipal> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="objectId">The object ID of the service principal for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwners: objectId: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsListOwnersResponse>
    /// <param name="objectId">The object ID of the service principal for which to get owners.</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: objectId: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="objectId">The object ID of the service principal for which to get owners.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwners: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Get the keyCredentials associated with the specified service principal.</summary>
    /// <param name="objectId">The object ID of the service principal for which to get keyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    abstract listKeyCredentials: objectId: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsListKeyCredentialsResponse>
    /// <param name="objectId">The object ID of the service principal for which to get keyCredentials.</param>
    /// <param name="callback">The callback</param>
    abstract listKeyCredentials: objectId: string * callback: ServiceCallback<KeyCredentialListResult> -> unit
    /// <param name="objectId">The object ID of the service principal for which to get keyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listKeyCredentials: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<KeyCredentialListResult> -> unit
    /// <summary>Update the keyCredentials associated with a service principal.</summary>
    /// <param name="objectId">The object ID for which to get service principal information.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    abstract updateKeyCredentials: objectId: string * value: ResizeArray<KeyCredential> * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID for which to get service principal information.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="callback">The callback</param>
    abstract updateKeyCredentials: objectId: string * value: ResizeArray<KeyCredential> * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID for which to get service principal information.</param>
    /// <param name="value">A collection of KeyCredentials.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract updateKeyCredentials: objectId: string * value: ResizeArray<KeyCredential> * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets the passwordCredentials associated with a service principal.</summary>
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="options">The optional parameters</param>
    abstract listPasswordCredentials: objectId: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsListPasswordCredentialsResponse>
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="callback">The callback</param>
    abstract listPasswordCredentials: objectId: string * callback: ServiceCallback<PasswordCredentialListResult> -> unit
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listPasswordCredentials: objectId: string * options: RequestOptionsBase * callback: ServiceCallback<PasswordCredentialListResult> -> unit
    /// <summary>Updates the passwordCredentials associated with a service principal.</summary>
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="options">The optional parameters</param>
    abstract updatePasswordCredentials: objectId: string * value: ResizeArray<PasswordCredential> * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="callback">The callback</param>
    abstract updatePasswordCredentials: objectId: string * value: ResizeArray<PasswordCredential> * callback: ServiceCallback<unit> -> unit
    /// <param name="objectId">The object ID of the service principal.</param>
    /// <param name="value">A collection of PasswordCredentials.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract updatePasswordCredentials: objectId: string * value: ResizeArray<PasswordCredential> * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets a list of service principals from the current tenant.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<ServicePrincipalListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<ServicePrincipalListResult> -> unit
    /// <summary>The owners are a set of non-admin users who are allowed to modify this object.</summary>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwnersNext: nextPageLink: string * ?options: RequestOptionsBase -> Promise<ServicePrincipalsListOwnersNextResponse>
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextPageLink">The NextLink from the previous successful call to List operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwnersNext: nextPageLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit

/// Class representing a ServicePrincipals.
type [<AllowNullLiteral>] ServicePrincipalsStatic =
    /// <summary>Create a ServicePrincipals.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> ServicePrincipals

type [<AllowNullLiteral>] ServicePrincipalsCreateResponse =
    inherit ServicePrincipal
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsGetResponse =
    inherit ServicePrincipal
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsListKeyCredentialsResponse =
    inherit KeyCredentialListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsListNextResponse =
    inherit ServicePrincipalListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] ServicePrincipalsListOptionalParams =
    inherit RequestOptionsBase
    /// The filter to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] ServicePrincipalsListOwnersNextResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsListOwnersResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsListPasswordCredentialsResponse =
    inherit PasswordCredentialListResult
    inherit HttpResponse

type [<AllowNullLiteral>] ServicePrincipalsListResponse =
    inherit ServicePrincipalListResult
    inherit HttpResponse

/// Request parameters for update an existing service principal.
type [<AllowNullLiteral>] ServicePrincipalUpdateParameters =
    inherit ServicePrincipalBase

/// Class representing a SignedInUser.
type [<AllowNullLiteral>] SignedInUser =
    /// <summary>Gets the details for the currently logged-in user.</summary>
    /// <param name="options">The optional parameters</param>
    abstract get: ?options: RequestOptionsBase -> Promise<SignedInUserGetResponse>
    /// <param name="callback">The callback</param>
    abstract get: callback: ServiceCallback<User> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: options: RequestOptionsBase * callback: ServiceCallback<User> -> unit
    /// <summary>Get the list of directory objects that are owned by the user.</summary>
    /// <param name="options">The optional parameters</param>
    abstract listOwnedObjects: ?options: RequestOptionsBase -> Promise<SignedInUserListOwnedObjectsResponse>
    /// <param name="callback">The callback</param>
    abstract listOwnedObjects: callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwnedObjects: options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <summary>Get the list of directory objects that are owned by the user.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listOwnedObjectsNext: nextLink: string * ?options: RequestOptionsBase -> Promise<SignedInUserListOwnedObjectsNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listOwnedObjectsNext: nextLink: string * callback: ServiceCallback<DirectoryObjectListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listOwnedObjectsNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<DirectoryObjectListResult> -> unit

/// Class representing a SignedInUser.
type [<AllowNullLiteral>] SignedInUserStatic =
    /// <summary>Create a SignedInUser.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> SignedInUser

type [<AllowNullLiteral>] SignedInUserGetResponse =
    inherit User
    inherit HttpResponse

type [<AllowNullLiteral>] SignedInUserListOwnedObjectsNextResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

type [<AllowNullLiteral>] SignedInUserListOwnedObjectsResponse =
    inherit DirectoryObjectListResult
    inherit HttpResponse

/// Contains information about a sign-in name of a local account user in an Azure Active Directory
/// B2C tenant.
type [<AllowNullLiteral>] SignInName =
    /// A string value that can be used to classify user sign-in types in your directory, such as
    /// 'emailAddress' or 'userName'.
    abstract ``type``: string option with get, set
    /// The sign-in used by the local account. Must be unique across the company/tenant. For example,
    /// 'johnc@example.com'.
    abstract value: string option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Active Directory user information.
type [<AllowNullLiteral>] User =
    /// Polymorphic Discriminator
    abstract objectType: string with get, set
    /// The object ID.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract objectId: string option
    /// The time at which the directory object was deleted.
    /// **NOTE: This property will not be serialized. It can only be populated by the server.**
    abstract deletionTimestamp: DateTime option
    /// This must be specified if you are using a federated domain for the user's userPrincipalName
    /// (UPN) property when creating a new user account. It is used to associate an on-premises Active
    /// Directory user account with their Azure AD user object.
    abstract immutableId: string option with get, set
    /// A two letter country code (ISO standard 3166). Required for users that will be assigned
    /// licenses due to legal requirement to check for availability of services in countries. Examples
    /// include: "US", "JP", and "GB".
    abstract usageLocation: string option with get, set
    /// The given name for the user.
    abstract givenName: string option with get, set
    /// The user's surname (family name or last name).
    abstract surname: string option with get, set
    /// A string value that can be used to classify user types in your directory, such as 'Member' and
    /// 'Guest'. Possible values include: 'Member', 'Guest'
    abstract userType: UserType option with get, set
    /// Whether the account is enabled.
    abstract accountEnabled: bool option with get, set
    /// The display name of the user.
    abstract displayName: string option with get, set
    /// The principal name of the user.
    abstract userPrincipalName: string option with get, set
    /// The mail alias for the user.
    abstract mailNickname: string option with get, set
    /// The primary email address of the user.
    abstract mail: string option with get, set
    /// The sign-in names of the user.
    abstract signInNames: ResizeArray<SignInName> option with get, set

/// An interface representing UserBase.
type [<AllowNullLiteral>] UserBase =
    /// This must be specified if you are using a federated domain for the user's userPrincipalName
    /// (UPN) property when creating a new user account. It is used to associate an on-premises Active
    /// Directory user account with their Azure AD user object.
    abstract immutableId: string option with get, set
    /// A two letter country code (ISO standard 3166). Required for users that will be assigned
    /// licenses due to legal requirement to check for availability of services in countries. Examples
    /// include: "US", "JP", and "GB".
    abstract usageLocation: string option with get, set
    /// The given name for the user.
    abstract givenName: string option with get, set
    /// The user's surname (family name or last name).
    abstract surname: string option with get, set
    /// A string value that can be used to classify user types in your directory, such as 'Member' and
    /// 'Guest'. Possible values include: 'Member', 'Guest'
    abstract userType: UserType option with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

/// Request parameters for creating a new work or school account user.
type [<AllowNullLiteral>] UserCreateParameters =
    inherit UserBase
    /// Whether the account is enabled.
    abstract accountEnabled: bool with get, set
    /// The display name of the user.
    abstract displayName: string with get, set
    /// Password Profile
    abstract passwordProfile: PasswordProfile with get, set
    /// The user principal name (someuser@contoso.com). It must contain one of the verified domains
    /// for the tenant.
    abstract userPrincipalName: string with get, set
    /// The mail alias for the user.
    abstract mailNickname: string with get, set
    /// The primary email address of the user.
    abstract mail: string option with get, set

/// Request parameters for GetMemberGroups API call.
type [<AllowNullLiteral>] UserGetMemberGroupsParameters =
    /// If true, only membership in security-enabled groups should be checked. Otherwise, membership
    /// in all groups should be checked.
    abstract securityEnabledOnly: bool with get, set
    /// Describes unknown properties. The value of an unknown property can be of "any" type.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: property: string -> obj option with get, set

type [<AllowNullLiteral>] UserGetMemberGroupsResult =
    inherit Array<string>

type [<AllowNullLiteral>] UserListResult =
    inherit Array<User>
    /// The URL to get the next set of results.
    abstract odatanextLink: string option with get, set

/// Class representing a Users.
type [<AllowNullLiteral>] Users =
    /// <summary>Create a new user.</summary>
    /// <param name="parameters">Parameters to create a user.</param>
    /// <param name="options">The optional parameters</param>
    abstract create: parameters: UserCreateParameters * ?options: RequestOptionsBase -> Promise<UsersCreateResponse>
    /// <param name="parameters">Parameters to create a user.</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: UserCreateParameters * callback: ServiceCallback<User> -> unit
    /// <param name="parameters">Parameters to create a user.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract create: parameters: UserCreateParameters * options: RequestOptionsBase * callback: ServiceCallback<User> -> unit
    /// <summary>Gets list of users for the current tenant.</summary>
    /// <param name="options">The optional parameters</param>
    abstract list: ?options: UsersListOptionalParams -> Promise<UsersListResponse>
    /// <param name="callback">The callback</param>
    abstract list: callback: ServiceCallback<UserListResult> -> unit
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract list: options: UsersListOptionalParams * callback: ServiceCallback<UserListResult> -> unit
    /// <summary>Gets user information from the directory.</summary>
    /// <param name="upnOrObjectId">The object ID or principal name of the user for which to get information.</param>
    /// <param name="options">The optional parameters</param>
    abstract get: upnOrObjectId: string * ?options: RequestOptionsBase -> Promise<UsersGetResponse>
    /// <param name="upnOrObjectId">The object ID or principal name of the user for which to get information.</param>
    /// <param name="callback">The callback</param>
    abstract get: upnOrObjectId: string * callback: ServiceCallback<User> -> unit
    /// <param name="upnOrObjectId">The object ID or principal name of the user for which to get information.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract get: upnOrObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<User> -> unit
    /// <summary>Updates a user.</summary>
    /// <param name="upnOrObjectId">The object ID or principal name of the user to update.</param>
    /// <param name="parameters">Parameters to update an existing user.</param>
    /// <param name="options">The optional parameters</param>
    abstract update: upnOrObjectId: string * parameters: UserUpdateParameters * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="upnOrObjectId">The object ID or principal name of the user to update.</param>
    /// <param name="parameters">Parameters to update an existing user.</param>
    /// <param name="callback">The callback</param>
    abstract update: upnOrObjectId: string * parameters: UserUpdateParameters * callback: ServiceCallback<unit> -> unit
    /// <param name="upnOrObjectId">The object ID or principal name of the user to update.</param>
    /// <param name="parameters">Parameters to update an existing user.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract update: upnOrObjectId: string * parameters: UserUpdateParameters * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Delete a user.</summary>
    /// <param name="upnOrObjectId">The object ID or principal name of the user to delete.</param>
    /// <param name="options">The optional parameters</param>
    abstract deleteMethod: upnOrObjectId: string * ?options: RequestOptionsBase -> Promise<RestResponse>
    /// <param name="upnOrObjectId">The object ID or principal name of the user to delete.</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: upnOrObjectId: string * callback: ServiceCallback<unit> -> unit
    /// <param name="upnOrObjectId">The object ID or principal name of the user to delete.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract deleteMethod: upnOrObjectId: string * options: RequestOptionsBase * callback: ServiceCallback<unit> -> unit
    /// <summary>Gets a collection that contains the object IDs of the groups of which the user is a member.</summary>
    /// <param name="objectId">The object ID of the user for which to get group membership.</param>
    /// <param name="parameters">User filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    abstract getMemberGroups: objectId: string * parameters: UserGetMemberGroupsParameters * ?options: RequestOptionsBase -> Promise<UsersGetMemberGroupsResponse>
    /// <param name="objectId">The object ID of the user for which to get group membership.</param>
    /// <param name="parameters">User filtering parameters.</param>
    /// <param name="callback">The callback</param>
    abstract getMemberGroups: objectId: string * parameters: UserGetMemberGroupsParameters * callback: ServiceCallback<UserGetMemberGroupsResult> -> unit
    /// <param name="objectId">The object ID of the user for which to get group membership.</param>
    /// <param name="parameters">User filtering parameters.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract getMemberGroups: objectId: string * parameters: UserGetMemberGroupsParameters * options: RequestOptionsBase * callback: ServiceCallback<UserGetMemberGroupsResult> -> unit
    /// <summary>Gets a list of users for the current tenant.</summary>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    abstract listNext: nextLink: string * ?options: RequestOptionsBase -> Promise<UsersListNextResponse>
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * callback: ServiceCallback<UserListResult> -> unit
    /// <param name="nextLink">Next link for the list operation.</param>
    /// <param name="options">The optional parameters</param>
    /// <param name="callback">The callback</param>
    abstract listNext: nextLink: string * options: RequestOptionsBase * callback: ServiceCallback<UserListResult> -> unit

/// Class representing a Users.
type [<AllowNullLiteral>] UsersStatic =
    /// <summary>Create a Users.</summary>
    /// <param name="client">Reference to the service client.</param>
    [<Emit "new $0($1...)">] abstract Create: client: GraphRbacManagementClientContext -> Users

type [<AllowNullLiteral>] UsersCreateResponse =
    inherit User
    inherit HttpResponse

type [<AllowNullLiteral>] UsersGetMemberGroupsResponse =
    inherit UserGetMemberGroupsResult
    inherit HttpResponse

type [<AllowNullLiteral>] UsersGetResponse =
    inherit User
    inherit HttpResponse

type [<AllowNullLiteral>] UsersListNextResponse =
    inherit UserListResult
    inherit HttpResponse

/// Optional Parameters.
type [<AllowNullLiteral>] UsersListOptionalParams =
    inherit RequestOptionsBase
    /// The filter to apply to the operation.
    abstract filter: string option with get, set

type [<AllowNullLiteral>] UsersListResponse =
    inherit UserListResult
    inherit HttpResponse

type [<StringEnum>] [<RequireQualifiedAccess>] UserType =
    | [<CompiledName "Member">] Member
    | [<CompiledName "Guest">] Guest

/// Request parameters for updating an existing work or school account user.
type [<AllowNullLiteral>] UserUpdateParameters =
    inherit UserBase
    /// Whether the account is enabled.
    abstract accountEnabled: bool option with get, set
    /// The display name of the user.
    abstract displayName: string option with get, set
    /// The password profile of the user.
    abstract passwordProfile: PasswordProfile option with get, set
    /// The user principal name (someuser@contoso.com). It must contain one of the verified domains
    /// for the tenant.
    abstract userPrincipalName: string option with get, set
    /// The mail alias for the user.
    abstract mailNickname: string option with get, set

type [<AllowNullLiteral>] Discriminators =
    abstract DirectoryObject: CompositeMapper with get, set
    abstract ``DirectoryObject.Application``: CompositeMapper with get, set
    abstract ``DirectoryObject.Group``: CompositeMapper with get, set
    abstract ``DirectoryObject.ServicePrincipal``: CompositeMapper with get, set
    abstract ``DirectoryObject.User``: CompositeMapper with get, set
