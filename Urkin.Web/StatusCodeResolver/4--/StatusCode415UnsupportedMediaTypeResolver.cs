using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 415 (unsupported media type) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode415UnsupportedMediaTypeResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 415 (unsupported media type) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 415 (unsupported media type)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(415);
        }
    }
}
