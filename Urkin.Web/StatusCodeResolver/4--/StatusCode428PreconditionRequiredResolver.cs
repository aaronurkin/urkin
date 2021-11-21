using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 428 (precondition required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode428PreconditionRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 428 (precondition required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 428 (precondition required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(428);
        }
    }
}
