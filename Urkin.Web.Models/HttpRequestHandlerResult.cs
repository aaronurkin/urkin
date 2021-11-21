namespace Urkin.Models
{
    /// <summary>
    /// An HTTP request handler result
    /// </summary>
    public class HttpRequestHandlerResult
    {
        /// <summary>
        /// Constructor initializes HTTP status code
        /// </summary>
        /// <param name="statusCode"></param>
        public HttpRequestHandlerResult(int statusCode)
            : this(default(object), statusCode)
        {
        }

        /// <summary>
        /// Constructor initializes HTTP status code and response data
        /// </summary>
        /// <param name="data">The response data</param>
        /// <param name="statusCode">The response status code</param>
        public HttpRequestHandlerResult(object data, int statusCode)
        {
            Data = data;
            StatusCode = statusCode;
        }

        /// <summary>
        /// Gets response data
        /// </summary>
        public object Data { get; }

        /// <summary>
        /// Gets response status code
        /// </summary>
        public int StatusCode { get; }
    }
}
