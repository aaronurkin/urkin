using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 412 (precondition failed) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode412PreconditionFailedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 412 (precondition failed) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 412 (precondition failed)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(412);
        }
    }
}
