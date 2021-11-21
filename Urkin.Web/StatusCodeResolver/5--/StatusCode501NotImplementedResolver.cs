using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 501 (not implemented) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode501NotImplementedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 501 (not implemented) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 501 (not implemented)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(501);
        }
    }
}
