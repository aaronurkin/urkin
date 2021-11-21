using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Provides actions to resolve HTTP status code to return response to a client
    /// </summary>
    public interface IStatusCodeResolver
    {
        /// <summary>
        /// Returns specified HTTP status code
        /// </summary>
        /// <returns>Specified HTTP status code</returns>
        Task<int> Resolve();
    }
}
