using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 201 (created) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode201CreatedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 201 (created) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 201 (created)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(201);
        }
    }
}
