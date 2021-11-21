using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 414 (request URI too long) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode414RequestUriTooLongResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 414 (request URI too long) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 414 (request URI too long)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(414);
        }
    }
}
