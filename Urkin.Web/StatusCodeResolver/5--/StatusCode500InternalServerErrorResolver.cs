using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 500 (internal server error) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode500InternalServerErrorResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 500 (internal server error) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 500 (internal server error)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(500);
        }
    }
}
