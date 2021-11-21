using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 203 (non authoritative information) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode203NonAuthoritativeInformationResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 203 (non authoritative information) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 203 (non authoritative information)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(203);
        }
    }
}
