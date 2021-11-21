using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 307 (temporary redirect) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode307TemporaryRedirectResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 307 (temporary redirect) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 307 (temporary redirect)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(307);
        }
    }
}
