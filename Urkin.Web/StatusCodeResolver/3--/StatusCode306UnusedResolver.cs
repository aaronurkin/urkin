using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 306 (unused) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode306UnusedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 306 (unused) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 306 (unused)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(306);
        }
    }
}
