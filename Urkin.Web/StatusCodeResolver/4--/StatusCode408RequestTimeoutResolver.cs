using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 408 (request timeout) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode408RequestTimeoutResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 408 (request timeout) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 408 (request timeout)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(408);
        }
    }
}
