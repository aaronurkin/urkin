using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 300 (ambiguous) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode300AmbiguousResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 300 (ambiguous) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 300 (ambiguous)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(300);
        }
    }
}
