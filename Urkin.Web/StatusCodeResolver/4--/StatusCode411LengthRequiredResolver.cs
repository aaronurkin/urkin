using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 411 (length required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode411LengthRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 411 (length required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 411 (length required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(411);
        }
    }
}
