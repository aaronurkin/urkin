using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 413 (request entity too large) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode413RequestEntityTooLargeResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 413 (request entity too large) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 413 (request entity too large)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(413);
        }
    }
}
