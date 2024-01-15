namespace Smooth.Result;

public class Result(bool isSuccess, int? statusCode, string? errorMessage)
{
    public bool IsSuccess { get; set; } = isSuccess;
    public int? StatusCode { get; set; } = statusCode;
    public string? ErrorMessage { get; set; } = errorMessage;

    /// <summary>
    /// Creates a successful result without a specific message.
    /// </summary>
    /// <returns>An instance of <see cref="Result"/> indicating success.</returns>
    public static Result OK() => new(true, default, default);
    
    /// <summary>
    /// Creates a failure result without a specific message or error code.
    /// </summary>
    /// <returns>An instance of <see cref="Result"/> indicating failure.</returns>
    public static Result Failure() => new(false, default, string.Empty);

    /// <summary>
    /// Creates a failure result with a specific error and a custom message.
    /// </summary>
    /// <param name="error">The error associated with the failure.</param>
    /// <param name="message">The custom message associated with the failure.</param>
    /// <returns>An instance of <see cref="Result"/> indicating failure with a specific error and a custom message.</returns>
    public static Result Failure(Error error, string message) => new(false, (int)error.ErrorTypes, message);

    /// <summary>
    /// Creates a failure result with a specific error.
    /// </summary>
    /// <param name="error">The error associated with the failure.</param>
    /// <returns>An instance of <see cref="Result"/> indicating failure with a specific error.</returns>
    public static Result Failure(Error error) => new(false, (int)error.ErrorTypes, error.ToString());
}