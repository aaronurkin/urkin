using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 507 (insufficient storage) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode507InsufficientStorageResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 507 (insufficient storage) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 507 (insufficient storage)</returns>
        public Task<int> Resolve()
    {
        return Task.FromResult(507);
    }
}
}
