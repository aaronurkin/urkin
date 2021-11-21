using System.Collections.Generic;
using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// Default validation logic
    /// </summary>
    /// <typeparam name="TValidatable">The type of the object to validate</typeparam>
    public class DefaultValidator<TValidatable> : IValidator<TValidatable>
    {
        /// <summary>
        /// Initializes next validator in the chain
        /// </summary>
        /// <param name="handlers">Handlers chain</param>
        public DefaultValidator(IEnumerable<IValidationHandler<TValidatable>> handlers)
        {
            this.Handlers = handlers ?? throw new System.ArgumentNullException(nameof(handlers));
        }

        /// <summary>
        /// Gets the validation handlers chain
        /// </summary>
        protected virtual IEnumerable<IValidationHandler<TValidatable>> Handlers { get; }

        /// <summary>
        /// Validates passed object
        /// </summary>
        /// <param name="validatable"></param>
        /// <returns>The aggregated <see cref="ValidationResult"/></returns>
        public virtual async Task<ValidationResult> Validate(TValidatable validatable)
        {
            var messages = new Dictionary<string, IEnumerable<string>>();

            foreach (var handler in this.Handlers)
            {
                var handlerResult = await handler.Validate(validatable);

                if (!handlerResult.Success)
                {
                    foreach (var item in handlerResult.Messages)
                    {
                        var keyMessages = !messages.TryGetValue(item.Key, out IEnumerable<string> previousKeyMessages)
                            ? new List<string>()
                            : new List<string>(previousKeyMessages);
                        keyMessages.AddRange(item.Value);
                        messages[item.Key] = keyMessages;
                    }
                }

                if (handlerResult.StopPropagation)
                {
                    break;
                }
            }

            return new ValidationResult(messages);
        }
    }
}
