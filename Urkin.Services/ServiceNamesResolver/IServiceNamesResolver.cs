using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// Provides actions to resolve services names based on application needs
    /// </summary>
    public interface IServiceNamesResolver
    {
        /// <summary>
        /// Resolves services names
        /// </summary>
        /// <returns>Collection of services names</returns>
        Task<ServiceNamesResult> Resolve();
    }
}
