using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 451 (unavailable for legal reasons) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode451UnavailableForLegalReasonsResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 451 (unavailable for legal reasons) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 451 (unavailable for legal reasons)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(451);
        }
    }
}
