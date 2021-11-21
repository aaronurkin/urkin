using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 406 (not acceptable) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode406NotAcceptableResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 406 (not acceptable) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 406 (not acceptable)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(406);
        }
    }
}
