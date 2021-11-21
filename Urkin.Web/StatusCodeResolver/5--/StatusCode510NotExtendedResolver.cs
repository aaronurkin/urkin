using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 510 (not extended) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode510NotExtendedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 510 (not extended) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 510 (not extended)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(510);
        }
    }
}
