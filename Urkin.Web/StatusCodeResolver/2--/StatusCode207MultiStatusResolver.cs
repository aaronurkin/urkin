using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 207 (multi status) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode207MultiStatusResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 207 (multi status) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 207 (multi status)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(207);
        }
    }
}
