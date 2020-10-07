// ts2fable 0.7.1
module rec Azure.Sdk.MsRest
open System
open Fable.Core
open Fable.Core.JS

type Blob = Browser.Types.Blob
type Event = interface end
type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
type RegExp = System.Text.RegularExpressions.Regex

let [<Import("*","@azure/ms-rest-azure-js")>] exports: IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract ApiKeyCredentials: ApiKeyCredentialsStatic
    abstract AzureServiceClient: AzureServiceClientStatic
    abstract CognitiveServicesCredentials: CognitiveServicesCredentialsStatic
    abstract createLROPollerFromInitialResponse: azureServiceClient: AzureServiceClient * initialResponse: HttpOperationResponse * ?options: RequestOptionsBase -> LROPoller
    abstract createLROPollerFromPollState: azureServiceClient: AzureServiceClient * lroMemento: LROPollState -> LROPoller
    abstract getDefaultUserAgentValue: unit -> string
    abstract LROPoller: LROPollerStatic
    abstract LROPollStrategy: LROPollStrategyStatic
    abstract RestError: RestErrorStatic
    abstract Serializer: SerializerStatic
    abstract ServiceClient: ServiceClientStatic
    abstract WebResource: WebResourceStatic

/// Allows the request to be aborted upon firing of the "abort" event.
/// Compatible with the browser built-in AbortSignal and common polyfills.
type [<AllowNullLiteral>] AbortSignalLike =
    abstract aborted: bool
    abstract dispatchEvent: (Event -> bool) with get, set
    abstract onabort: (AbortSignalLike -> Event -> obj option) option with get, set
    abstract addEventListener: ((AbortSignalLike -> Event -> obj option) -> obj -> unit) with get, set
    abstract removeEventListener: ((AbortSignalLike -> Event -> obj option) -> obj -> unit) with get, set

type [<AllowNullLiteral>] AdditionalInfoElement =
    abstract ``type``: string option with get, set
    abstract info: string option with get, set

type [<AllowNullLiteral>] ApiKeyCredentialOptions =
    /// A key value pair of the header parameters that need to be applied to the request.
    abstract inHeader: ApiKeyCredentialOptionsInHeader option with get, set
    /// A key value pair of the query parameters that need to be applied to the request.
    abstract inQuery: ApiKeyCredentialOptionsInHeader option with get, set

/// Authenticates to a service using an API key.
type [<AllowNullLiteral>] ApiKeyCredentials =
    inherit ServiceClientCredentials
    /// <summary>Signs a request with the values provided in the inHeader and inQuery parameter.</summary>
    /// <param name="webResource">The WebResource to be signed.</param>
    abstract signRequest: webResource: WebResourceLike -> Promise<WebResourceLike>

/// Authenticates to a service using an API key.
type [<AllowNullLiteral>] ApiKeyCredentialsStatic =
    /// <param name="options">Specifies the options to be provided for auth. Either header or query needs to be provided.</param>
    [<Emit "new $0($1...)">] abstract Create: options: ApiKeyCredentialOptions -> ApiKeyCredentials

type [<AllowNullLiteral>] AzureServiceClient =
    inherit ServiceClient
    abstract acceptLanguage: string with get, set
    /// The retry timeout in seconds for Long Running Operations. Default value is 30.
    abstract longRunningOperationRetryTimeout: float option with get, set
    /// <summary>Send the initial request of a LRO (long running operation) and get back an
    /// LROPoller that provides methods for polling the LRO and checking if the LRO is finished.</summary>
    /// <param name="operationArguments">The arguments to the operation.</param>
    /// <param name="operationSpec">The specification for the operation.</param>
    /// <param name="options">Additional options to be sent while making the request.</param>
    abstract sendLRORequest: operationArguments: OperationArguments * operationSpec: OperationSpec * ?options: RequestOptionsBase -> Promise<LROPoller>
    /// <summary>Provides a mechanism to make a request that will poll and provide the final result.</summary>
    /// <param name="request">- The request object</param>
    /// <param name="options">Additional options to be sent while making the request</param>
    abstract sendLongRunningRequest: request: U2<RequestPrepareOptions, WebResource> * ?options: RequestOptionsBase -> Promise<HttpOperationResponse>
    /// <summary>Send the initial request of a LRO (long running operation) and get back an
    /// HttpLongRunningOperationResponse that provides methods for polling the LRO and checking if the
    /// LRO is finished.</summary>
    /// <param name="request">- The request object</param>
    /// <param name="options">Additional options to be sent while making the request</param>
    abstract beginLongRunningRequest: request: U2<RequestPrepareOptions, WebResource> * ?options: RequestOptionsBase -> Promise<LROPoller>
    /// Restore an LROPoller from the provided LROPollState. This method can be used to recreate an
    /// LROPoller on a different process or machine.
    abstract restoreLROPoller: lroPollState: LROPollState -> LROPoller

type [<AllowNullLiteral>] AzureServiceClientStatic =
    [<Emit "new $0($1...)">] abstract Create: credentials: ServiceClientCredentials * ?options: AzureServiceClientOptions -> AzureServiceClient

/// Options to be provided while creating the client.
type [<AllowNullLiteral>] AzureServiceClientOptions =
    inherit ServiceClientOptions
    abstract acceptLanguage: string option with get, set
    abstract longRunningOperationRetryTimeout: float option with get, set

type [<AllowNullLiteral>] BaseMapper =
    abstract xmlName: string option with get, set
    abstract xmlIsAttribute: bool option with get, set
    abstract xmlElementName: string option with get, set
    abstract xmlIsWrapped: bool option with get, set
    abstract readOnly: bool option with get, set
    abstract isConstant: bool option with get, set
    abstract required: bool option with get, set
    abstract nullable: bool option with get, set
    abstract serializedName: string option with get, set
    abstract ``type``: MapperType with get, set
    abstract defaultValue: obj option with get, set
    abstract constraints: MapperConstraints option with get, set

type [<AllowNullLiteral>] BaseResource =
    interface end

type [<AllowNullLiteral; AbstractClass>] CloudError =
    inherit Error
    abstract code: string with get, set
    abstract message: string with get, set
    abstract target: string option with get, set
    abstract details: Array<CloudError> option with get, set
    abstract innerError: obj option with get, set
    abstract additionalInfo: AdditionalInfoElement option with get, set

/// Creates a new CognitiveServicesCredentials object.
type [<AllowNullLiteral>] CognitiveServicesCredentials =
    inherit ApiKeyCredentials

/// Creates a new CognitiveServicesCredentials object.
type [<AllowNullLiteral>] CognitiveServicesCredentialsStatic =
    [<Emit "new $0($1...)">] abstract Create: subscriptionKey: string -> CognitiveServicesCredentials

type [<AllowNullLiteral>] CompositeMapper =
    inherit BaseMapper
    abstract ``type``: CompositeMapperType with get, set

type [<AllowNullLiteral>] CompositeMapperType =
    abstract name: string with get, set
    abstract className: string option with get, set
    abstract modelProperties: CompositeMapperTypeModelProperties option with get, set
    abstract additionalProperties: Mapper option with get, set
    abstract uberParent: string option with get, set
    abstract polymorphicDiscriminator: PolymorphicDiscriminator option with get, set

/// The content-types that will indicate that an operation response should be deserialized in a
/// particular way.
type [<AllowNullLiteral>] DeserializationContentTypes =
    /// The content-types that indicate that an operation response should be deserialized as JSON.
    /// Defaults to [ "application/json", "text/json" ].
    abstract json: ResizeArray<string> option with get, set
    /// The content-types that indicate that an operation response should be deserialized as XML.
    /// Defaults to [ "application/xml", "application/atom+xml" ].
    abstract xml: ResizeArray<string> option with get, set

type [<AllowNullLiteral>] DictionaryMapper =
    inherit BaseMapper
    abstract ``type``: DictionaryMapperType with get, set
    abstract headerCollectionPrefix: string option with get, set

type [<AllowNullLiteral>] DictionaryMapperType =
    abstract name: string with get, set
    abstract value: Mapper with get, set

type [<AllowNullLiteral>] EnumMapper =
    inherit BaseMapper
    abstract ``type``: EnumMapperType with get, set

type [<AllowNullLiteral>] EnumMapperType =
    abstract name: string with get, set
    abstract allowedValues: ResizeArray<obj option> with get, set

/// An interface that can send HttpRequests and receive promised HttpResponses.
type [<AllowNullLiteral>] HttpClient =
    inherit RequestPolicy

/// An individual header within a HttpHeaders collection.
type [<AllowNullLiteral>] HttpHeader =
    /// The name of the header.
    abstract name: string with get, set
    /// The value of the header.
    abstract value: string with get, set

/// A collection of HTTP header key/value pairs.
type [<AllowNullLiteral>] HttpHeadersLike =
    /// <summary>Set a header in this collection with the provided name and value. The name is
    /// case-insensitive.</summary>
    /// <param name="headerName">The name of the header to set. This value is case-insensitive.</param>
    /// <param name="headerValue">The value of the header to set.</param>
    abstract set: headerName: string * headerValue: U2<string, float> -> unit
    /// <summary>Get the header value for the provided header name, or undefined if no header exists in this
    /// collection with the provided name.</summary>
    /// <param name="headerName">The name of the header.</param>
    abstract get: headerName: string -> string option
    /// Get whether or not this header collection contains a header entry for the provided header name.
    abstract contains: headerName: string -> bool
    /// <summary>Remove the header with the provided headerName. Return whether or not the header existed and
    /// was removed.</summary>
    /// <param name="headerName">The name of the header to remove.</param>
    abstract remove: headerName: string -> bool
    /// Get the headers that are contained this collection as an object.
    abstract rawHeaders: unit -> RawHttpHeaders
    /// Get the headers that are contained in this collection as an array.
    abstract headersArray: unit -> ResizeArray<HttpHeader>
    /// Get the header names that are contained in this collection.
    abstract headerNames: unit -> ResizeArray<string>
    /// Get the header values that are contained in this collection.
    abstract headerValues: unit -> ResizeArray<string>
    /// Create a deep clone/copy of this HttpHeaders collection.
    abstract clone: unit -> HttpHeadersLike
    /// Get the JSON object representation of this HTTP header collection.
    /// The result is the same as `rawHeaders()`.
    abstract toJson: unit -> RawHttpHeaders

type [<StringEnum>] [<RequireQualifiedAccess>] HttpMethods =
    | [<CompiledName "GET">] GET
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "POST">] POST
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "PATCH">] PATCH
    | [<CompiledName "HEAD">] HEAD
    | [<CompiledName "OPTIONS">] OPTIONS
    | [<CompiledName "TRACE">] TRACE

/// Wrapper object for http request and response. Deserialized object is stored in
/// the `parsedBody` property when the response body is received in JSON or XML.
type [<AllowNullLiteral>] HttpOperationResponse =
    inherit HttpResponse
    /// The parsed HTTP response headers.
    abstract parsedHeaders: HttpOperationResponseParsedHeaders option with get, set
    /// The response body as text (string format)
    abstract bodyAsText: string option with get, set
    /// The response body as parsed JSON or XML
    abstract parsedBody: obj option with get, set
    /// BROWSER ONLY
    /// 
    /// The response body as a browser Blob.
    /// Always undefined in node.js.
    abstract blobBody: Promise<Blob> option with get, set

/// A Logger that can be added to a HttpPipeline. This enables each RequestPolicy to log messages
/// that can be used for debugging purposes.
type [<AllowNullLiteral>] HttpPipelineLogger =
    /// The log level threshold for what logs will be logged.
    abstract minimumLogLevel: HttpPipelineLogLevel with get, set
    /// <summary>Log the provided message.</summary>
    /// <param name="logLevel">The HttpLogDetailLevel associated with this message.</param>
    /// <param name="message">The message to log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

type [<RequireQualifiedAccess>] HttpPipelineLogLevel =
    | OFF = 0
    | ERROR = 1
    | WARNING = 2
    | INFO = 3

/// The properties on an HTTP response which will always be present.
type [<AllowNullLiteral>] HttpResponse =
    /// The raw request
    abstract request: WebResourceLike with get, set
    /// The HTTP response status (e.g. 200)
    abstract status: float with get, set
    /// The HTTP response headers.
    abstract headers: HttpHeadersLike with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] LongRunningOperationStates =
    | [<CompiledName "InProgress">] InProgress
    | [<CompiledName "Succeeded">] Succeeded
    | [<CompiledName "Failed">] Failed
    | [<CompiledName "Canceled">] Canceled
    | [<CompiledName "Cancelled">] Cancelled

/// An HTTP operation response that provides special methods for interacting with LROs (long running
/// operations).
type [<AllowNullLiteral>] LROPoller =
    /// Get the first response that the service sent back when the LRO was initiated.
    abstract getInitialResponse: unit -> HttpOperationResponse
    /// Get the most recent response that the service sent back during this LRO.
    abstract getMostRecentResponse: unit -> HttpOperationResponse
    /// Get whether or not the LRO is finished.
    abstract isFinished: unit -> bool
    /// Get whether or not the LRO is finished and its final state is acceptable. If the LRO has not
    /// finished yet, then undefined will be returned. An "acceptable" final state is determined by the
    /// LRO strategy that the Azure service uses to perform long running operations.
    abstract isFinalStatusAcceptable: unit -> bool option
    /// Get the current status of the LRO.
    abstract getOperationStatus: unit -> LongRunningOperationStates
    /// If the LRO is finished and in an acceptable state, then return the HttpOperationResponse. If
    /// the LRO is finished and not in an acceptable state, then throw the error that the LRO produced.
    /// If the LRO is not finished, then return undefined.
    abstract getOperationResponse: unit -> Promise<HttpOperationResponse option>
    /// Send a single poll request and return the LRO's state.
    abstract poll: unit -> Promise<LongRunningOperationStates>
    /// Send poll requests that check the LRO's status until it is determined that the LRO is finished.
    abstract pollUntilFinished: unit -> Promise<RestResponse>
    /// Get an LROPollState object that can be used to poll this LRO in a different context (such as on
    /// a different process or a different machine). If the LRO couldn't produce an LRO polling
    /// strategy, then this will return undefined.
    abstract getPollState: unit -> LROPollState option

/// An HTTP operation response that provides special methods for interacting with LROs (long running
/// operations).
type [<AllowNullLiteral>] LROPollerStatic =
    /// <summary>Create a new HttpLongRunningOperationResponse.</summary>
    /// <param name="_lroPollStrategy">The LROPollStrategy that this HttpLongRunningOperationResponse will
    /// use to interact with the LRO.</param>
    [<Emit "new $0($1...)">] abstract Create: _lroPollStrategy: LROPollStrategy option * _initialResponse: HttpOperationResponse -> LROPoller

type [<AllowNullLiteral>] LROPollState =
    abstract pollStrategyType: LROPollStrategyType with get, set
    abstract initialResponse: HttpOperationResponse with get, set
    abstract state: LongRunningOperationStates with get, set
    abstract mostRecentRequest: WebResource with get, set
    abstract mostRecentResponse: HttpOperationResponse with get, set
    abstract resource: obj option with get, set
    abstract azureAsyncOperationHeaderValue: string option with get, set
    abstract locationHeaderValue: string option with get, set
    abstract options: RequestOptionsBase option with get, set

/// A long-running operation polling strategy base class that other polling strategies should extend.
type [<AllowNullLiteral>] LROPollStrategy =
    abstract _pollState: LROPollState
    abstract getOperationStatus: unit -> LongRunningOperationStates
    /// Get whether or not this poll strategy's LRO is finished.
    abstract isFinished: unit -> bool
    /// Send poll requests that check the LRO's status until it is determined that the LRO is finished.
    abstract pollUntilFinished: unit -> Promise<bool>
    /// Send a single poll request that checks the LRO's status and return the response. If the LRO is
    /// finished, then no request will be sent and the last response received will be returned.
    abstract sendPollRequest: unit -> Promise<unit>
    abstract isFinalStatusAcceptable: unit -> bool
    abstract shouldDoFinalGetResourceRequest: unit -> bool
    abstract doFinalGetResourceRequest: unit -> Promise<unit>
    abstract getMostRecentResponse: unit -> HttpOperationResponse
    abstract getOperationResponse: unit -> Promise<HttpOperationResponse>
    abstract getRestError: unit -> RestError
    abstract updateState: url: string * shouldDeserialize: U2<bool, (HttpOperationResponse -> bool)> -> Promise<unit>
    /// <summary>Retrieves operation status by querying the operation URL.</summary>
    /// <param name="statusUrl">URL used to poll operation result.</param>
    abstract updateOperationStatus: statusUrl: string * shouldDeserialize: U2<bool, (HttpOperationResponse -> bool)> -> Promise<HttpOperationResponse>
    abstract getPollState: unit -> LROPollState

/// A long-running operation polling strategy base class that other polling strategies should extend.
type [<AllowNullLiteral>] LROPollStrategyStatic =
    [<Emit "new $0($1...)">] abstract Create: _azureServiceClient: AzureServiceClient * _pollState: LROPollState -> LROPollStrategy

type [<StringEnum>] [<RequireQualifiedAccess>] LROPollStrategyType =
    | [<CompiledName "AzureAsyncOperation">] AzureAsyncOperation
    | [<CompiledName "Location">] Location
    | [<CompiledName "GetResource">] GetResource

type Mapper =
    U5<BaseMapper, CompositeMapper, SequenceMapper, DictionaryMapper, EnumMapper>

type [<AllowNullLiteral>] MapperConstraints =
    abstract InclusiveMaximum: float option with get, set
    abstract ExclusiveMaximum: float option with get, set
    abstract InclusiveMinimum: float option with get, set
    abstract ExclusiveMinimum: float option with get, set
    abstract MaxLength: float option with get, set
    abstract MinLength: float option with get, set
    abstract Pattern: RegExp option with get, set
    abstract MaxItems: float option with get, set
    abstract MinItems: float option with get, set
    abstract UniqueItems: obj option with get, set
    abstract MultipleOf: float option with get, set

type MapperType =
    U5<SimpleMapperType, CompositeMapperType, SequenceMapperType, DictionaryMapperType, EnumMapperType>

/// A collection of properties that apply to a single invocation of an operation.
type [<AllowNullLiteral>] OperationArguments =
    /// The parameters that were passed to the operation method.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: parameterName: string -> obj option with get, set
    /// The optional arugments that are provided to an operation.
    abstract options: RequestOptionsBase option with get, set

/// A common interface that all Operation parameter's extend.
type [<AllowNullLiteral>] OperationParameter =
    /// The path to this parameter's value in OperationArguments or the object that contains paths for
    /// each property's value in OperationArguments.
    abstract parameterPath: ParameterPath with get, set
    /// The mapper that defines how to validate and serialize this parameter's value.
    abstract mapper: Mapper with get, set

/// A parameter for an operation that will be added as a query parameter to the operation's HTTP
/// request.
type [<AllowNullLiteral>] OperationQueryParameter =
    inherit OperationParameter
    /// Whether or not to skip encoding the query parameter's value before adding it to the URL.
    abstract skipEncoding: bool option with get, set
    /// If this query parameter's value is a collection, what type of format should the value be
    /// converted to.
    abstract collectionFormat: QueryCollectionFormat option with get, set

/// An OperationResponse that can be returned from an operation request for a single status code.
type [<AllowNullLiteral>] OperationResponse =
    /// The mapper that will be used to deserialize the response headers.
    abstract headersMapper: Mapper option with get, set
    /// The mapper that will be used to deserialize the response body.
    abstract bodyMapper: Mapper option with get, set

/// A specification that defines an operation.
type [<AllowNullLiteral>] OperationSpec =
    /// The serializer to use in this operation.
    abstract serializer: Serializer
    /// The HTTP method that should be used by requests for this operation.
    abstract httpMethod: HttpMethods
    /// The URL that was provided in the service's specification. This will still have all of the URL
    /// template variables in it. If this is not provided when the OperationSpec is created, then it
    /// will be populated by a "baseUri" property on the ServiceClient.
    abstract baseUrl: string option
    /// The fixed path for this operation's URL. This will still have all of the URL template variables
    /// in it.
    abstract path: string option
    /// The content type of the request body. This value will be used as the "Content-Type" header if
    /// it is provided.
    abstract contentType: string option
    /// The parameter that will be used to construct the HTTP request's body.
    abstract requestBody: OperationParameter option
    /// Whether or not this operation uses XML request and response bodies.
    abstract isXML: bool option
    /// The parameters to the operation method that will be substituted into the constructed URL.
    abstract urlParameters: ReadonlyArray<OperationURLParameter> option
    /// The parameters to the operation method that will be added to the constructed URL's query.
    abstract queryParameters: ReadonlyArray<OperationQueryParameter> option
    /// The parameters to the operation method that will be converted to headers on the operation's
    /// HTTP request.
    abstract headerParameters: ReadonlyArray<OperationParameter> option
    /// The parameters to the operation method that will be used to create a formdata body for the
    /// operation's HTTP request.
    abstract formDataParameters: ReadonlyArray<OperationParameter> option
    /// The different types of responses that this operation can return based on what status code is
    /// returned.
    abstract responses: OperationSpecResponses

/// A parameter for an operation that will be substituted into the operation's request URL.
type [<AllowNullLiteral>] OperationURLParameter =
    inherit OperationParameter
    /// Whether or not to skip encoding the URL parameter's value before adding it to the URL.
    abstract skipEncoding: bool option with get, set

type ParameterPath =
    U3<string, ResizeArray<string>, IParameterPath>
type IParameterPath =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> ParameterPath with get, set

/// The Parameter value provided for path or query parameters in RequestPrepareOptions
type [<AllowNullLiteral>] ParameterValue =
    abstract value: obj option with get, set
    abstract skipUrlEncoding: bool with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] PolymorphicDiscriminator =
    abstract serializedName: string with get, set
    abstract clientName: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

/// HTTP proxy settings (Node.js only)
type [<AllowNullLiteral>] ProxySettings =
    abstract host: string with get, set
    abstract port: float with get, set
    abstract username: string option with get, set
    abstract password: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] QueryCollectionFormat =
    | [<CompiledName ",">] Csv
    | [<CompiledName " ">] Ssv
    | [<CompiledName "	">] Tsv
    | [<CompiledName "|">] Pipes
    | [<CompiledName "Multi">] Multi

type [<AllowNullLiteral>] RawHttpHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: headerName: string -> string with get, set

/// Describes the base structure of the options object that will be used in every operation.
type [<AllowNullLiteral>] RequestOptionsBase =
    abstract customHeaders: RequestOptionsBaseCustomHeaders option with get, set
    /// The signal which can be used to abort requests.
    abstract abortSignal: AbortSignalLike option with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    abstract timeout: float option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] RequestPolicy =
    abstract sendRequest: httpRequest: WebResourceLike -> Promise<HttpOperationResponse>

type [<AllowNullLiteral>] RequestPolicyFactory =
    abstract create: nextPolicy: RequestPolicy * options: RequestPolicyOptionsLike -> RequestPolicy

/// Optional properties that can be used when creating a RequestPolicy.
type [<AllowNullLiteral>] RequestPolicyOptionsLike =
    /// <summary>Get whether or not a log with the provided log level should be logged.</summary>
    /// <param name="logLevel">The log level of the log that will be logged.</param>
    abstract shouldLog: logLevel: HttpPipelineLogLevel -> bool
    /// <summary>Attempt to log the provided message to the provided logger. If no logger was provided or if
    /// the log level does not meet the logger's threshold, then nothing will be logged.</summary>
    /// <param name="logLevel">The log level of this log.</param>
    /// <param name="message">The message of this log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

type [<AllowNullLiteral>] RequestPrepareOptions =
    /// The HTTP request method. Valid values are "GET", "PUT", "HEAD", "DELETE", "OPTIONS", "POST",
    /// or "PATCH".
    abstract ``method``: HttpMethods with get, set
    /// The request url. It may or may not have query parameters in it. Either provide the "url" or
    /// provide the "pathTemplate" in the options object. Both the options are mutually exclusive.
    abstract url: string option with get, set
    /// A dictionary of query parameters to be appended to the url, where
    /// the "key" is the "query-parameter-name" and the "value" is the "query-parameter-value".
    /// The "query-parameter-value" can be of type "string" or it can be of type "object".
    /// The "object" format should be used when you want to skip url encoding. While using the object format,
    /// the object must have a property named value which provides the "query-parameter-value".
    /// Example:
    ///     - query-parameter-value in "object" format: { "query-parameter-name": { value: "query-parameter-value", skipUrlEncoding: true } }
    ///     - query-parameter-value in "string" format: { "query-parameter-name": "query-parameter-value"}.
    /// Note: "If options.url already has some query parameters, then the value provided in options.queryParameters will be appended to the url.
    abstract queryParameters: RequestPrepareOptionsQueryParameters option with get, set
    /// The path template of the request url. Either provide the "url" or provide the "pathTemplate" in
    /// the options object. Both the options are mutually exclusive.
    /// Example: "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}"
    abstract pathTemplate: string option with get, set
    /// The base url of the request. Default value is: "https://management.azure.com". This is
    /// applicable only with pathTemplate. If you are providing options.url then it is expected that
    /// you provide the complete url.
    abstract baseUrl: string option with get, set
    /// A dictionary of path parameters that need to be replaced with actual values in the pathTemplate.
    /// Here the key is the "path-parameter-name" and the value is the "path-parameter-value".
    /// The "path-parameter-value" can be of type "string"  or it can be of type "object".
    /// The "object" format should be used when you want to skip url encoding. While using the object format,
    /// the object must have a property named value which provides the "path-parameter-value".
    /// Example:
    ///     - path-parameter-value in "object" format: { "path-parameter-name": { value: "path-parameter-value", skipUrlEncoding: true } }
    ///     - path-parameter-value in "string" format: { "path-parameter-name": "path-parameter-value" }.
    abstract pathParameters: RequestPrepareOptionsQueryParameters option with get, set
    abstract formData: HttpOperationResponseParsedHeaders option with get, set
    /// A dictionary of request headers that need to be applied to the request.
    /// Here the key is the "header-name" and the value is the "header-value". The header-value MUST be of type string.
    ///   - ContentType must be provided with the key name as "Content-Type". Default value "application/json; charset=utf-8".
    ///   - "Transfer-Encoding" is set to "chunked" by default if "options.bodyIsStream" is set to true.
    ///   - "Content-Type" is set to "application/octet-stream" by default if "options.bodyIsStream" is set to true.
    ///   - "accept-language" by default is set to "en-US"
    ///   - "x-ms-client-request-id" by default is set to a new Guid. To not generate a guid for the request, please set options.disableClientRequestId to true
    abstract headers: HttpOperationResponseParsedHeaders option with get, set
    /// When set to true, instructs the client to not set "x-ms-client-request-id" header to a new Guid().
    abstract disableClientRequestId: bool option with get, set
    /// The request body. It can be of any type. This value will be serialized if it is not a stream.
    abstract body: obj option with get, set
    /// Provides information on how to serialize the request body.
    abstract serializationMapper: Mapper option with get, set
    /// A dictionary of mappers that may be used while [de]serialization.
    abstract mappers: ApiKeyCredentialOptionsInHeader option with get, set
    /// Provides information on how to deserialize the response body.
    abstract deserializationMapper: obj option with get, set
    /// Indicates whether this method should JSON.stringify() the request body. Default value: false.
    abstract disableJsonStringifyOnBody: bool option with get, set
    /// Indicates whether the request body is a stream (useful for file upload scenarios).
    abstract bodyIsStream: bool option with get, set
    abstract abortSignal: AbortSignalLike option with get, set
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set

type [<AllowNullLiteral; AbstractClass>] RestError =
    inherit Error
    abstract code: string option with get, set
    abstract statusCode: float option with get, set
    abstract request: WebResourceLike option with get, set
    abstract response: HttpOperationResponse option with get, set
    abstract body: obj option with get, set

type [<AllowNullLiteral>] RestErrorStatic =
    abstract REQUEST_SEND_ERROR: string
    abstract REQUEST_ABORTED_ERROR: string
    abstract PARSE_ERROR: string
    [<Emit "new $0($1...)">] abstract Create: message: string * ?code: string * ?statusCode: float * ?request: WebResourceLike * ?response: HttpOperationResponse * ?body: obj -> RestError

/// The flattened response to a REST call.
/// Contains the underlying HttpOperationResponse as well as
/// the merged properties of the parsedBody, parsedHeaders, etc.
type [<AllowNullLiteral>] RestResponse =
    /// The underlying HTTP response containing both raw and deserialized response data.
    abstract _response: HttpOperationResponse with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] SequenceMapper =
    inherit BaseMapper
    abstract ``type``: SequenceMapperType with get, set

type [<AllowNullLiteral>] SequenceMapperType =
    abstract name: string with get, set
    abstract element: Mapper with get, set

type [<AllowNullLiteral>] Serializer =
    abstract modelMappers: HttpOperationResponseParsedHeaders
    abstract isXML: bool option
    abstract validateConstraints: mapper: Mapper * value: obj option * objectName: string -> unit
    /// <summary>Serialize the given object based on its metadata defined in the mapper</summary>
    /// <param name="mapper">The mapper which defines the metadata of the serializable object</param>
    /// <param name="object">A valid Javascript object to be serialized</param>
    /// <param name="objectName">Name of the serialized object</param>
    abstract serialize: mapper: Mapper * ``object``: obj option * ?objectName: string -> obj option
    /// <summary>Deserialize the given object based on its metadata defined in the mapper</summary>
    /// <param name="mapper">The mapper which defines the metadata of the serializable object</param>
    /// <param name="responseBody">A valid Javascript entity to be deserialized</param>
    /// <param name="objectName">Name of the deserialized object</param>
    abstract deserialize: mapper: Mapper * responseBody: obj option * objectName: string -> obj option

type [<AllowNullLiteral>] SerializerStatic =
    [<Emit "new $0($1...)">] abstract Create: ?modelMappers: SerializerStaticModelMappers * ?isXML: bool -> Serializer

type [<AllowNullLiteral>] SerializerStaticModelMappers =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Service callback that is returned for REST requests initiated by the service client.
type [<AllowNullLiteral>] ServiceCallback<'TResult> =
    /// <summary>A method that will be invoked as a callback to a service function.</summary>
    /// <param name="err">The error occurred if any, while executing the request; otherwise null.</param>
    /// <param name="result">The deserialized response body if an error did not occur.</param>
    /// <param name="request">The raw/actual request sent to the server if an error did not occur.</param>
    /// <param name="response">The raw/actual response from the server if an error did not occur.</param>
    [<Emit "$0($1...)">] abstract Invoke: err: U2<Error, RestError> option * ?result: 'TResult * ?request: WebResourceLike * ?response: HttpOperationResponse -> unit

type [<AllowNullLiteral>] ServiceClient =
    /// If specified, this is the base URI that requests will be made against for this ServiceClient.
    /// If it is not specified, then all OperationSpecs must contain a baseUrl property.
    abstract baseUri: string option with get, set
    /// The default request content type for the service.
    /// Used if no requestContentType is present on an OperationSpec.
    abstract requestContentType: string option with get, set
    /// Send the provided httpRequest.
    abstract sendRequest: options: U2<RequestPrepareOptions, WebResourceLike> -> Promise<HttpOperationResponse>
    /// <summary>Send an HTTP request that is populated using the provided OperationSpec.</summary>
    /// <param name="operationArguments">The arguments that the HTTP request's templated values will be populated from.</param>
    /// <param name="operationSpec">The OperationSpec to use to populate the httpRequest.</param>
    /// <param name="callback">The callback to call when the response is received.</param>
    abstract sendOperationRequest: operationArguments: OperationArguments * operationSpec: OperationSpec * ?callback: ServiceCallback<obj option> -> Promise<RestResponse>

type [<AllowNullLiteral>] ServiceClientStatic =
    /// <summary>The ServiceClient constructor</summary>
    /// <param name="credentials">The credentials object used for authentication.</param>
    /// <param name="options">The service client options that govern the behavior of the client.</param>
    [<Emit "new $0($1...)">] abstract Create: ?credentials: ServiceClientCredentials * ?options: ServiceClientOptions -> ServiceClient

type [<AllowNullLiteral>] ServiceClientCredentials =
    /// <summary>Signs a request with the Authentication header.</summary>
    /// <param name="webResource">The WebResourceLike/request to be signed.</param>
    abstract signRequest: webResource: WebResourceLike -> Promise<WebResourceLike>

/// Options to be provided while creating the client.
type [<AllowNullLiteral>] ServiceClientOptions =
    /// An array of factories which get called to create the RequestPolicy pipeline used to send a HTTP
    /// request on the wire, or a function that takes in the defaultRequestPolicyFactories and returns
    /// the requestPolicyFactories that will be used.
    abstract requestPolicyFactories: U2<ResizeArray<RequestPolicyFactory>, (ResizeArray<RequestPolicyFactory> -> U2<unit, ResizeArray<RequestPolicyFactory>>)> option with get, set
    /// The HttpClient that will be used to send HTTP requests.
    abstract httpClient: HttpClient option with get, set
    /// The HttpPipelineLogger that can be used to debug RequestPolicies within the HTTP pipeline.
    abstract httpPipelineLogger: HttpPipelineLogger option with get, set
    /// If set to true, turn off the default retry policy.
    abstract noRetryPolicy: bool option with get, set
    /// Gets or sets the retry timeout in seconds for AutomaticRPRegistration. Default value is 30.
    abstract rpRegistrationRetryTimeout: float option with get, set
    /// Whether or not to generate a client request ID header for each HTTP request.
    abstract generateClientRequestIdHeader: bool option with get, set
    /// Whether to include credentials in CORS requests in the browser.
    /// See https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials for more information.
    abstract withCredentials: bool option with get, set
    /// If specified, a GenerateRequestIdPolicy will be added to the HTTP pipeline that will add a
    /// header to all outgoing requests with this header name and a random UUID as the request ID.
    abstract clientRequestIdHeaderName: string option with get, set
    /// The content-types that will be associated with JSON or XML serialization.
    abstract deserializationContentTypes: DeserializationContentTypes option with get, set
    /// The header name to use for the telemetry header while sending the request. If this is not
    /// specified, then "User-Agent" will be used when running on Node.js and "x-ms-command-name" will
    /// be used when running in a browser.
    abstract userAgentHeaderName: U2<string, (string -> string)> option with get, set
    /// The string to be set to the telemetry header while sending the request, or a function that
    /// takes in the default user-agent string and returns the user-agent string that will be used.
    abstract userAgent: U2<string, (string -> string)> option with get, set
    /// Proxy settings which will be used for every HTTP request (Node.js only).
    abstract proxySettings: ProxySettings option with get, set

type [<AllowNullLiteral>] SimpleMapperType =
    abstract name: SimpleMapperTypeName with get, set

type [<AllowNullLiteral>] TransferProgressEvent =
    /// The number of bytes loaded so far.
    abstract loadedBytes: float with get, set

/// Creates a new WebResource object.
/// 
/// This class provides an abstraction over a REST call by being library / implementation agnostic and wrapping the necessary
/// properties to initiate a request.
type [<AllowNullLiteral>] WebResource =
    abstract url: string with get, set
    abstract ``method``: HttpMethods with get, set
    abstract body: obj option with get, set
    abstract headers: HttpHeadersLike with get, set
    /// Whether or not the body of the HttpOperationResponse should be treated as a stream.
    abstract streamResponseBody: bool option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, (HttpOperationResponse -> bool)> option with get, set
    /// A function that returns the proper OperationResponse for the given OperationSpec and
    /// HttpOperationResponse combination. If this is undefined, then a simple status code lookup will
    /// be used.
    abstract operationResponseGetter: (OperationSpec -> HttpOperationResponse -> OperationResponse option) option with get, set
    abstract formData: obj option with get, set
    abstract query: HttpOperationResponseParsedHeaders option with get, set
    abstract operationSpec: OperationSpec option with get, set
    abstract withCredentials: bool with get, set
    abstract timeout: float with get, set
    abstract proxySettings: ProxySettings option with get, set
    abstract keepAlive: bool option with get, set
    abstract abortSignal: AbortSignalLike option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Validates that the required properties such as method, url, headers["Content-Type"],
    /// headers["accept-language"] are defined. It will throw an error if one of the above
    /// mentioned properties are not defined.
    abstract validateRequestProperties: unit -> unit
    /// <summary>Prepares the request.</summary>
    /// <param name="options">Options to provide for preparing the request.</param>
    abstract prepare: options: RequestPrepareOptions -> WebResource
    /// Clone this WebResource HTTP request object.
    abstract clone: unit -> WebResource

/// Creates a new WebResource object.
/// 
/// This class provides an abstraction over a REST call by being library / implementation agnostic and wrapping the necessary
/// properties to initiate a request.
type [<AllowNullLiteral>] WebResourceStatic =
    [<Emit "new $0($1...)">] abstract Create: ?url: string * ?``method``: HttpMethods * ?body: obj * ?query: WebResourceStaticQuery * ?headers: U2<HttpOperationResponseParsedHeaders, HttpHeadersLike> * ?streamResponseBody: bool * ?withCredentials: bool * ?abortSignal: AbortSignalLike * ?timeout: float * ?onUploadProgress: (TransferProgressEvent -> unit) * ?onDownloadProgress: (TransferProgressEvent -> unit) * ?proxySettings: ProxySettings * ?keepAlive: bool -> WebResource

type [<AllowNullLiteral>] WebResourceStaticQuery =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// An abstraction over a REST call.
type [<AllowNullLiteral>] WebResourceLike =
    /// The URL being accessed by the request.
    abstract url: string with get, set
    /// The HTTP method to use when making the request.
    abstract ``method``: HttpMethods with get, set
    /// The HTTP body contents of the request.
    abstract body: obj option with get, set
    /// The HTTP headers to use when making the request.
    abstract headers: HttpHeadersLike with get, set
    /// Whether or not the body of the HttpOperationResponse should be treated as a stream.
    abstract streamResponseBody: bool option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, (HttpOperationResponse -> bool)> option with get, set
    /// A function that returns the proper OperationResponse for the given OperationSpec and
    /// HttpOperationResponse combination. If this is undefined, then a simple status code lookup will
    /// be used.
    abstract operationResponseGetter: (OperationSpec -> HttpOperationResponse -> OperationResponse option) option with get, set
    abstract formData: obj option with get, set
    /// A query string represented as an object.
    abstract query: HttpOperationResponseParsedHeaders option with get, set
    /// Used to parse the response.
    abstract operationSpec: OperationSpec option with get, set
    /// If credentials (cookies) should be sent along during an XHR.
    abstract withCredentials: bool with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    /// If the request is terminated, an `AbortError` is thrown.
    abstract timeout: float with get, set
    /// Proxy configuration.
    abstract proxySettings: ProxySettings option with get, set
    /// If the connection should be reused.
    abstract keepAlive: bool option with get, set
    /// Used to abort the request later.
    abstract abortSignal: AbortSignalLike option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Validates that the required properties such as method, url, headers["Content-Type"],
    /// headers["accept-language"] are defined. It will throw an error if one of the above
    /// mentioned properties are not defined.
    abstract validateRequestProperties: unit -> unit
    /// Sets options on the request.
    abstract prepare: options: RequestPrepareOptions -> WebResourceLike
    /// Clone this request object.
    abstract clone: unit -> WebResourceLike


type [<AllowNullLiteral>] ApiKeyCredentialOptionsInHeader =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: x: string -> obj option with get, set

type [<AllowNullLiteral>] CompositeMapperTypeModelProperties =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> Mapper with get, set

type [<AllowNullLiteral>] HttpOperationResponseParsedHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] OperationSpecResponses =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: responseCode: string -> OperationResponse with get, set

type [<AllowNullLiteral>] RequestOptionsBaseCustomHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] RequestPrepareOptionsQueryParameters =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<obj option, ParameterValue> with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] SimpleMapperTypeName =
    | [<CompiledName "Base64Url">] Base64Url
    | [<CompiledName "Boolean">] Boolean
    | [<CompiledName "ByteArray">] ByteArray
    | [<CompiledName "Date">] Date
    | [<CompiledName "DateTime">] DateTime
    | [<CompiledName "DateTimeRfc1123">] DateTimeRfc1123
    | [<CompiledName "Object">] Object
    | [<CompiledName "Stream">] Stream
    | [<CompiledName "String">] String
    | [<CompiledName "TimeSpan">] TimeSpan
    | [<CompiledName "UnixTime">] UnixTime
    | [<CompiledName "Uuid">] Uuid
    | [<CompiledName "Number">] Number
    | Any
