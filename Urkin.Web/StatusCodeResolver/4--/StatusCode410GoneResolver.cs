using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 410 (gone) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode410GoneResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 410 (gone) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 410 (gone)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(410);
        }
    }
}
