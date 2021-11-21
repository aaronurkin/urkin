using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 226 (IMUsed) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode226IMUsedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 226 (IMUsed) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 226 (IMUsed)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(226);
        }
    }
}
