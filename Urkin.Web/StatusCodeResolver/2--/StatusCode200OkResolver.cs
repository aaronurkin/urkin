using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 200 (ok) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode200OkResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 200 (ok) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 200 (ok)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(200);
        }
    }
}
