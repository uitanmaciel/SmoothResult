namespace Smooth.Result;

public record Error(ErrorTypes ErrorTypes, string Message)
{
    public static readonly Error None = new(ErrorTypes.None, string.Empty);
    
    /// <summary>
    /// Represents a BadRequest error. This error is triggered when the server cannot understand the request
    /// due to malformed syntax.
    /// </summary>
    /// <returns>Returns an Error object with the BadRequest type and a message detailing the issue.</returns>
    public static Error BadRequest
        => new(ErrorTypes.BadRequest, "Your request could not be understood due to malformed syntax.");
    
    /// <summary>
    /// Represents an Unauthorized error. This error occurs when authentication has failed or has not been provided,
    /// yet it is required.
    /// </summary>
    /// <returns>Returns an Error object with the Unauthorized type and a message detailing the issue.</returns>
    public static Error Unauthorized
        => new(ErrorTypes.Unauthorized, "Authentication is required and has failed or has not been provided.");
    
    /// <summary>
    /// Represents a PaymentRequired error. This error indicates that payment is required to access the requested resource.
    /// </summary>
    /// <returns>Returns an Error object with the PaymentRequired type and a message detailing the issue.</returns>
    public static Error PaymentRequired
        => new(ErrorTypes.PaymentRequired, "Payment is required to access this resource.");

    /// <summary>
    /// Represents a Forbidden error. This error occurs when the user does not have the necessary permissions
    /// to access the resource.
    /// </summary>
    /// <returns>Returns an Error object with the Forbidden type and a message detailing the issue.</returns>
    public static Error Forbidden
        => new(ErrorTypes.Forbidden, "You do not have the necessary permissions to access this resource.");

    /// <summary>
    /// Represents a NotFound error. This error is triggered when the requested resource cannot be found.
    /// </summary>
    /// <returns>Returns an Error object with the NotFound type and a message detailing the issue.</returns>
    public static Error NotFound
        => new(ErrorTypes.NotFound, "The requested resource could not be found.");

    /// <summary>
    /// Represents a MethodNotAllowed error. This error occurs when the HTTP method used in the request is not allowed
    /// for the targeted resource.
    /// </summary>
    /// <returns>Returns an Error object with the MethodNotAllowed type and a message detailing the issue.</returns>
    public static Error MethodNotAllowed
        => new(ErrorTypes.MethodNotAllowed, "The method specified in the request is not allowed for the resource identified.");

    /// <summary>
    /// Represents a NotAcceptable error. This error occurs when the resource is unable to generate content acceptable
    /// to the client, as dictated by the Accept headers sent in the request.
    /// </summary>
    /// <returns>Returns an Error object with the NotAcceptable type and a message detailing the issue.</returns>
    public static Error NotAcceptable
        => new(ErrorTypes.NotAcceptable, "The resource is capable of generating only content not acceptable according to the Accept headers sent in the request.");
    
    /// <summary>
    /// Represents a ProxyAuthenticationRequired error. This error is triggered when authentication with a proxy server
    /// is required before the request can be served.
    /// </summary>
    /// <returns>Returns an Error object with the ProxyAuthenticationRequired type and a message detailing the issue.</returns>
    public static Error ProxyAuthenticationRequired
        => new(ErrorTypes.ProxyAuthenticationRequired, "You must authenticate with a proxy server before this request can be served.");

    /// <summary>
    /// Represents a RequestTimeout error. This error is triggered when the server times out waiting for the request.
    /// </summary>
    /// <returns>Returns an Error object with the RequestTimeout type and a message detailing the issue.</returns>
    public static Error RequestTimeout
        => new(ErrorTypes.RequestTimeout, "The server timed out waiting for the request.");
    
    /// <summary>
    /// Represents a Conflict error. This error occurs when the request could not be completed due to a conflict with
    /// the current state of the resource.
    /// </summary>
    /// <returns>Returns an Error object with the Conflict type and a message detailing the issue.</returns>
    public static Error Conflict
        => new(ErrorTypes.Conflict, "The request could not be completed due to a conflict with the current state of the resource.");
    
    /// <summary>
    /// Represents a Gone error. This error is triggered when the requested resource is no longer available at the
    /// server and no forwarding address is known.
    /// </summary>
    /// <returns>Returns an Error object with the Gone type and a message detailing the issue.</returns>
    public static Error Gone
        => new(ErrorTypes.Gone, "The requested resource is no longer available at the server and no forwarding address is known.");

    /// <summary>
    /// Represents a LengthRequired error. This error occurs when the request does not specify the length of its content,
    /// which is required by the requested resource.
    /// </summary>
    /// <returns>Returns an Error object with the LengthRequired type and a message detailing the issue.</returns>
    public static Error LengthRequired
        => new(ErrorTypes.LengthRequired, "The request did not specify the length of its content, which is required by the requested resource.");

    /// <summary>
    /// Represents a PreconditionFailed error. This error occurs when one or more preconditions given in the request
    /// header fields evaluated to false when tested on the server.
    /// </summary>
    /// <returns>Returns an Error object with the PreconditionFailed type and a message detailing the issue.</returns>
    public static Error PreconditionFailed
        => new(ErrorTypes.PreconditionFailed, "One or more preconditions given in the request header fields evaluated to false when tested on the server.");

    /// <summary>
    /// Represents a PayloadTooLarge error. This error is triggered when the server refuses to process a request because
    /// the request payload is larger than the server is willing or able to process.
    /// </summary>
    /// <returns>Returns an Error object with the PayloadTooLarge type and a message detailing the issue.</returns>
    public static Error PayloadTooLarge
        => new(ErrorTypes.PayloadTooLarge, "The server is refusing to process a request because the request payload is larger than the server is willing or able to process.");

    /// <summary>
    /// Represents a UriTooLong error. This error occurs when the provided URI is too long for the server to process.
    /// </summary>
    /// <returns>Returns an Error object with the UriTooLong type and a message detailing the issue.</returns>
    public static Error UriToLong
        => new(ErrorTypes.UriToLong, "The URI provided was too long for the server to process.");
    
    /// <summary>
    /// Represents an UnsupportedMediaType error. This error occurs when the server refuses to service the request because
    /// the entity of the request is in a format not supported by the requested resource for the requested method.
    /// </summary>
    /// <returns>Returns an Error object with the UnsupportedMediaType type and a message detailing the issue.</returns>
    public static Error UnsupportedMediaType
        => new(ErrorTypes.UnsupportedMediaType, "The server is refusing to service the request because the entity of the request is in a format not supported by the requested resource for the requested method.");
    
    /// <summary>
    /// Represents a RangeNotSatisfiable error. This error occurs when the server cannot serve the requested ranges.
    /// </summary>
    /// <returns>Returns an Error object with the RangeNotSatisfiable type and a message detailing the issue.</returns>
    public static Error RangeNotSatisfiable
        => new(ErrorTypes.RangeNotSatisfiable, "The server cannot serve the requested ranges.");

    /// <summary>
    /// Represents an ExpectationFailed error. This error occurs when the server cannot meet the requirements of the Expect request-header field.
    /// </summary>
    /// <returns>Returns an Error object with the ExpectationFailed type and a message detailing the issue.</returns>
    public static Error ExpectationFailed
        => new(ErrorTypes.ExpectationFailed, "The server cannot meet the requirements of the Expect request-header field.");

    /// <summary>
    /// Represents a MisdirectedRequest error. This error occurs when the request was directed at a server that is not able to produce a response.
    /// </summary>
    /// <returns>Returns an Error object with the MisdirectedRequest type and a message detailing the issue.</returns>
    public static Error MisdirectedRequest
        => new(ErrorTypes.MisdirectedRequest, "The request was directed at a server that is not able to produce a response.");

    /// <summary>
    /// Represents an UnprocessableContent error. This error occurs when the server understands the content type of the
    /// request entity but was unable to process the contained instructions.
    /// </summary>
    /// <returns>Returns an Error object with the UnprocessableContent type and a message detailing the issue.</returns>
    public static Error UnprocessableContent
        => new(ErrorTypes.UnprocessableContent, "The server understands the content type of the request entity, but was unable to process the contained instructions.");

    /// <summary>
    /// Represents a Locked error. This error occurs when the resource that is being accessed is locked.
    /// </summary>
    /// <returns>Returns an Error object with the Locked type and a message detailing the issue.</returns>
    public static Error Locked
        => new(ErrorTypes.Locked, "The resource that is being accessed is locked.");

    /// <summary>
    /// Represents a FailedDependency error. This error occurs when the request failed due to the failure of a previous request.
    /// </summary>
    /// <returns>Returns an Error object with the FailedDependency type and a message detailing the issue.</returns>
    public static Error FailedDependency
        => new(ErrorTypes.FailedDependency, "The request failed due to the failure of a previous request.");

    /// <summary>
    /// Represents a TooEarly error. This error indicates the server is unwilling to risk processing a request that might be replayed.
    /// </summary>
    /// <returns>Returns an Error object with the TooEarly type and a message detailing the issue.</returns>
    public static Error TooEarly
        => new(ErrorTypes.TooEarly, "The server is unwilling to risk processing a request that might be replayed.");

    /// <summary>
    /// Represents an UpgradeRequired error. This error occurs when the client is advised to switch to a different protocol.
    /// </summary>
    /// <returns>Returns an Error object with the UpgradeRequired type and a message detailing the issue.</returns>
    public static Error UpgradeRequired
        => new(ErrorTypes.UpgradeRequired, "The client should switch to a different protocol.");

    /// <summary>
    /// Represents a PreconditionRequired error. This error indicates the server requires the request to be conditional.
    /// </summary>
    /// <returns>Returns an Error object with the PreconditionRequired type and a message detailing the issue.</returns>
    public static Error PreconditionRequired
        => new(ErrorTypes.PreconditionRequired, "The server requires the request to be conditional.");

    /// <summary>
    /// Represents a TooManyRequests error. This error occurs when the user has sent too many requests in a given amount of time.
    /// </summary>
    /// <returns>Returns an Error object with the TooManyRequests type and a message detailing the issue.</returns>
    public static Error TooManyRequests
        => new(ErrorTypes.TooManyRequests, "You have sent too many requests in a given amount of time.");

    /// <summary>
    /// Represents a RequestHeaderFieldsTooLarge error. This error occurs when the server is unwilling to process the request
    /// because its header fields are too large.
    /// </summary>
    /// <returns>Returns an Error object with the RequestHeaderFieldsTooLarge type and a message detailing the issue. </returns>
    public static Error RequestHeaderFieldsTooLarge
        => new(ErrorTypes.RequestHeaderFieldsTooLarge, "The server is unwilling to process the request because its header fields are too large.");

    /// <summary>
    /// Represents an UnavailableForLegalReasons error. This error occurs when the requested resource is unavailable due to legal reasons.
    /// </summary>
    /// <returns>Returns an Error object with the UnavailableForLegalReasons type and a message detailing the issue.</returns>
    public static Error UnavailableForLegalReasons
        => new(ErrorTypes.UnavailableForLegalReasons, "The requested resource is unavailable due to legal reasons.");

    /// <summary>
    /// Represents an InternalServerError. This error occurs when the server encountered an unexpected condition that prevented it from fulfilling the request.
    /// </summary>
    /// <returns>Returns an Error object with the InternalServerError type and a message detailing the issue.</returns>
    public static Error InternalServerError
        => new(ErrorTypes.InternalServerError, "The server encountered an unexpected condition that prevented it from fulfilling the request.");

    /// <summary>
    /// Represents a NotImplemented error. This error occurs when the server does not support the functionality required to fulfill the request.
    /// </summary>
    /// <returns>Returns an Error object with the NotImplemented type and a message detailing the issue.</returns>
    public static Error NotImplemented
        => new(ErrorTypes.NotImplemented, "The server does not support the functionality required to fulfill the request.");

    /// <summary>
    /// Represents a BadGateway error. This error occurs when the server received an invalid response from the upstream server.
    /// </summary>
    /// <returns>Returns an Error object with the BadGateway type and a message detailing the issue.</returns>
    public static Error BadGateway
        => new(ErrorTypes.BadGateway, "The server received an invalid response from the upstream server.");

    /// <summary>
    /// Represents a ServiceUnavailable error. This error occurs when the server is temporarily overloaded or under
    /// maintenance and cannot handle the request.
    /// </summary>
    /// <returns>Returns an Error object with the ServiceUnavailable type and a message detailing the issue.</returns>
    public static Error ServiceUnavailable
        => new(ErrorTypes.ServiceUnavailable, "The server is currently unable to handle the request due to a temporary overloading or maintenance of the server.");

    /// <summary>
    /// Represents a GatewayTimeout error. This error occurs when the upstream server fails to send a request in the time allowed by the server.
    /// </summary>
    /// <returns>Returns an Error object with the GatewayTimeout type and a message detailing the issue.</returns>
    public static Error GatewayTimeout
        => new(ErrorTypes.GatewayTimeout, "The upstream server failed to send a request in the time allowed by the server.");

    /// <summary>
    /// Represents an HttpVersionNotSupported error. This error occurs when the server does not support the HTTP protocol version used in the request.
    /// </summary>
    /// <returns>Returns an Error object with the HttpVersionNotSupported type and a message detailing the issue.</returns>
    public static Error HttpVersionNotSupported
        => new(ErrorTypes.HttpVersionNotSupported, "The server does not support the HTTP protocol version that was used in the request.");

    /// <summary>
    /// Represents a VariantAlsoNegotiates error. This error indicates an internal server configuration error where the chosen variant resource is not a suitable endpoint in the negotiation process.
    /// </summary>
    /// <returns>Returns an Error object with the VariantAlsoNegotiates type and a message detailing the issue.</returns>
    public static Error VariantAlsoNegotiates
        => new(ErrorTypes.VariantAlsoNegotiates, "The server has an internal configuration error: the chosen variant resource is configured to engage in transparent content negotiation and is therefore not a suitable endpoint in the negotiation process.");

    /// <summary>
    /// Represents an InsufficientStorage error. This error occurs when the server is unable to store the representation needed to complete the request.
    /// </summary>
    /// <returns>Returns an Error object with the InsufficientStorage type and a message detailing the issue.</returns>
    public static Error InsufficientStorage
        => new(ErrorTypes.InsufficientStorage, "The server is unable to store the representation needed to complete the request.");

    /// <summary>
    /// Represents a LoopDetected error. This error occurs when the server detects an infinite loop while processing the request.
    /// </summary>
    /// <returns>Returns an Error object with the LoopDetected type and a message detailing the issue.</returns>
    public static Error LoopDetected
        => new(ErrorTypes.LoopDetected, "The server detected an infinite loop while processing the request.");

    /// <summary>
    /// Represents a NotExtended error. This error indicates that further extensions to the request are required for the server to fulfill it.
    /// </summary>
    /// <returns>Returns an Error object with the NotExtended type and a message detailing the issue.</returns>
    public static Error NotExtended
        => new(ErrorTypes.NotExtended, "Further extensions to the request are required for the server to fulfill it.");

    /// <summary>
    /// Represents a NetworkAuthenticationRequired error. This error occurs when the client needs to authenticate to gain network access.
    /// </summary>
    /// <returns>Returns an Error object with the NetworkAuthenticationRequired type and a message detailing the issue.</returns>
    public static Error NetworkAuthenticationRequired
        => new(ErrorTypes.NetworkAuthenticationRequired, "The client needs to authenticate to gain network access.");
    
    public override string ToString()
        => $"{ErrorTypes}: {Message}";
}