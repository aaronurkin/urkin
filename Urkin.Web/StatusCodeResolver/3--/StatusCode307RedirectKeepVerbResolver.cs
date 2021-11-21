using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 307 (redirect keep verb) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode307RedirectKeepVerbResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 307 (redirect keep verb) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 307 (redirect keep verb)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(307);
        }
    }
}
