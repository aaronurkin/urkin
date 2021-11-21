using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 205 (reset content) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode205ResetContentResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 205 (reset content) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 205 (reset content)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(205);
        }
    }
}
