using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 301 (moved permanently) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode301MovedPermanentlyResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 301 (moved permanently) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 301 (moved permanently)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(301);
        }
    }
}
