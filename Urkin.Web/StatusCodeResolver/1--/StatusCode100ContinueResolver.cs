using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 100 (continue) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode100ContinueResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 100 (continue) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 100 (continue)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(100);
        }
    }
}
