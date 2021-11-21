using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 424 (failed dependency) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode424FailedDependencyResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 424 (failed dependency) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 424 (failed dependency)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(424);
        }
    }
}
