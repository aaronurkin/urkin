using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 300 (multiple choices) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode300MultipleChoicesResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 300 (multiple choices) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 300 (multiple choices)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(300);
        }
    }
}
