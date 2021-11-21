using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 423 (locked) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode423LockedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 423 (locked) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 423 (locked)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(423);
        }
    }
}
