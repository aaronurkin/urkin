using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 508 (loop detected) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode508LoopDetectedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 508 (loop detected) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 508 (loop detected)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(508);
        }
    }
}
