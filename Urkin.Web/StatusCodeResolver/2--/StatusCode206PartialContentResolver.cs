using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 206 (partial content) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode206PartialContentResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 206 (partial content) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 206 (partial content)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(206);
        }
    }
}
