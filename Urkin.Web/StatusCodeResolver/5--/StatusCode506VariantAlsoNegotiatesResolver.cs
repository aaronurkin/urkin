using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 506 (variant also negotiates) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode506VariantAlsoNegotiatesResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 506 (variant also negotiates) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 506 (variant also negotiates)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(506);
        }
    }
}
