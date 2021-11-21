using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 103 (early hints) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode103EarlyHintsResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 103 (early hints) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 103 (early hints)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(103);
        }
    }
}
