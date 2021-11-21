using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 208 (already reported) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode208AlreadyReportedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 208 (already reported) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 208 (already reported)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(208);
        }
    }
}
