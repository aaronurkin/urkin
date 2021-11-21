using System.Collections.Generic;
using System.Linq;

namespace Urkin.Models
{
    /// <summary>
    /// Represents validation result
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Initializes instance without messages
        /// </summary>
        public ValidationResult()
            : this(default(IDictionary<string, IEnumerable<string>>))
        {
        }

        /// <summary>
        /// Initializes validation messages
        /// </summary>
        /// <param name="messages">Messages value</param>
        public ValidationResult(IDictionary<string, IEnumerable<string>> messages)
            : this(default(bool), messages)
        {
        }

        /// <summary>
        /// Initializes the stop propagation flag
        /// </summary>
        public ValidationResult(bool stopPropagation)
            : this(stopPropagation, default(IDictionary<string, IEnumerable<string>>))
        {
        }

        /// <summary>
        /// Initializes validation messages and the stop propagation flag
        /// </summary>
        /// <param name="messages">Messages value</param>
        /// <param name="stopPropagation">Stop propagation value</param>
        public ValidationResult(bool stopPropagation, IDictionary<string, IEnumerable<string>> messages)
        {
            this.Messages = messages;
            this.StopPropagation = stopPropagation;
        }

        /// <summary>
        /// Gets stop propagation flag
        /// </summary>
        public bool StopPropagation { get; }

        /// <summary>
        /// Gets validation result flag
        /// </summary>
        public bool Success => !this.Messages?.Any() ?? true;

        /// <summary>
        /// Gets validation messages
        /// </summary>
        public IDictionary<string, IEnumerable<string>> Messages { get; }
    }
}
