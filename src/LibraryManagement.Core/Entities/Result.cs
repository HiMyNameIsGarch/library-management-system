namespace LibraryManagement.Core.Entities
{
    // Generic Result class is used to represent the result of an operation
    // with a success status, data, and an optional message
    public class Result<T>
    {
        // Properties
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }

        // Basic methods for the Result class
        public static Result<T> Success(T data) => new()
        {
            IsSuccess = true,
            Data = data
        };
        public static Result<T> Fail(string message) => new()
        {
            IsSuccess = false,
            Message = message
        };
    }
}
