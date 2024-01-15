namespace Smooth.Result;

public class Result<T>(bool isSuccess, int? statusCode, string? errorMessage, T? data)
{
    public bool IsSuccess { get; set; } = isSuccess;
    public int? StatusCode { get; set; } = statusCode;
    public string? ErrorMessage { get; set; } = errorMessage;
    public T? Data { get; set; } = data;
    
    /// <summary>
    /// Creates a successful result without any data or message.
    /// </summary>
    /// <returns>Returns a success Result object without data or a message.</returns>
    public static Result<T> Ok() => new(true, default, string.Empty, default);

    /// <summary>
    /// Creates a successful result with the specified data.
    /// </summary>
    /// <param name="data">The data to include in the success result.</param>
    /// <returns>Returns a success Result object containing the specified data.</returns>
    public static Result<T> Ok(T data) => new(true, default, string.Empty, data);

    /// <summary>
    /// Creates a failure result without any data or message.
    /// </summary>
    /// <returns>Returns a failure Result object without data or a message.</returns>
    public static Result<T> Failure() => new(false, default, string.Empty, default);

    /// <summary>
    /// Creates a failure result with a message but without any data.
    /// </summary>
    /// <param name="message">A message describing the failure result.</param>
    /// <returns>Returns a failure Result object containing the specified message.</returns>
    public static Result<T> Failure(string message) => new(false, default, message, default);

    /// <summary>
    /// Creates a failure result with the specified error object but without any data.
    /// </summary>
    /// <param name="error">The Error object to include in the failure result.</param>
    /// <returns>Returns a failure Result object containing the error message.</returns>
    public static Result<T> Failure(Error error) => new(false, (int)error.ErrorTypes, error.ToString(), default);
}