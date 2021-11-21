using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 426 (upgrade required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode426UpgradeRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 426 (upgrade required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 426 (upgrade required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(426);
        }
    }
}
