using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 303 (see other) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode303SeeOtherResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 303 (see other) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 303 (see other)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(303);
        }
    }
}
