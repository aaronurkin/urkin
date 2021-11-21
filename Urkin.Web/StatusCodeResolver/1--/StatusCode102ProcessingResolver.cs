using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 102 (processing) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode102ProcessingResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 102 (processing) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 102 (processing)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(102);
        }
    }
}
