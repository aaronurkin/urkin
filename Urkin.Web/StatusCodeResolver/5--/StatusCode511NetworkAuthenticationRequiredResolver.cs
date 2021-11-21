using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 511 (network authentication required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode511NetworkAuthenticationRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 511 (network authentication required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 511 (network authentication required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(511);
        }
    }
}
