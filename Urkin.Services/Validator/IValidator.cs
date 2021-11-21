using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// Generic objects validator
    /// </summary>
    /// <typeparam name="TValidatable">The type of the object to validate</typeparam>
    public interface IValidator<TValidatable>
    {
        /// <summary>
        /// Validates object
        /// </summary>
        /// <param name="validatable">Object to validate</param>
        /// <returns>The <see cref="ValidationResult"/> instance</returns>
        Task<ValidationResult> Validate(TValidatable validatable);
    }
}
