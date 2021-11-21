using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 422 (unprocessable entity) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode422UnprocessableEntityResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 422 (unprocessable entity) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 422 (unprocessable entity)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(422);
        }
    }
}
