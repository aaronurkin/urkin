using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 417 (expectation failed) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode417ExpectationFailedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 417 (expectation failed) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 417 (expectation failed)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(417);
        }
    }
}
