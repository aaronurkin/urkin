using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// The concrete validator within the validation chain
    /// </summary>
    /// <typeparam name="TValidatable">The type of the object to validate</typeparam>
    public interface IValidationHandler<TValidatable>
    {
        /// <summary>
        /// Validates passed object
        /// </summary>
        /// <param name="validatable">Object to validate</param>
        /// <returns>The <see cref="ValidationResult"/> instance</returns>
        Task<ValidationResult> Validate(TValidatable validatable);
    }
}
