using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 402 (payment required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode402PaymentRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 402 (payment required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 402 (payment required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(402);
        }
    }
}
