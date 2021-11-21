using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 202 (accepted) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode202AcceptedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 202 (accepted) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 202 (accepted)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(202);
        }
    }
}
