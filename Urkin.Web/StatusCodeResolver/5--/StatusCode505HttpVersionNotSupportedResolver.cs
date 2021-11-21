using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 505 (HTTP version not supported) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode505HttpVersionNotSupportedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 505 (HTTP version not supported) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 505 (HTTP version not supported)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(505);
        }
    }
}
