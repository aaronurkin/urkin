using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// Implements business logic for a received data
    /// </summary>
    /// <typeparam name="TModel">The type of the received data</typeparam>
    public interface IApplicationManager<TModel>
    {
        /// <summary>
        /// Encapsulates business logic for a received data
        /// </summary>
        /// <param name="model">The received data</param>
        /// <returns>An instance of <see cref="ApplicationManagerResult"/> with the type of a result
        /// or <seealso cref="ApplicationManagerResult{TData}"/>with the type of a result and data</returns>
        Task<ApplicationManagerResult> Manage(TModel model);
    }
}
