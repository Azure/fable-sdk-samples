## Fable/React Single Page Application

The simple application demonstrates authenticating against Azure AD with [msal.js](https://github.com/AzureAD/microsoft-authentication-library-for-js/) and making a request with the [Azure Graph SDK](https://github.com/Azure/azure-sdk-for-js/tree/master/sdk/graphrbac/graph).

### Preparing the sample
- Register an Azure AD application.
- In authentication options add SPA client and specify `http://localhost:8090` as a redirect URI.
- modify `options.json` with your Azure subscription, tenant and your application IDs.

### Calling other APIs
- Update the SDK generation project and generate corresponding bindings
- Update `options.json` with the corresponding API scope
- Provide the `MsRest.ServiceClientCredentials` interface implementation into the client