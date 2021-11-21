using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 400 (bad request) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode400BadRequestResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 400 (bad request) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 400 (bad request)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(400);
        }
    }
}
