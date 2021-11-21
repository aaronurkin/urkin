using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 101 (switching protocols) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode101SwitchingProtocolsResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 101 (switching protocols) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 101 (switching protocols)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(101);
        }
    }
}
