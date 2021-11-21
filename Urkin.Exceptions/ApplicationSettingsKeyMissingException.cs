using System.Runtime.Serialization;

namespace Urkin.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a key is missing within application settings
    /// </summary>
    public class ApplicationSettingsKeyMissingException : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSettingsKeyMissingException"/> class with the missing application setting name.
        /// </summary>
        /// <param name="key">The key that is missing</param>
        public ApplicationSettingsKeyMissingException(string key)
            : this (key, default(System.Exception))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSettingsKeyMissingException"/> class with the missing application setting name and the exception that is the cause of this exception.
        /// </summary>
        /// <param name="key">The key that is missing</param>
        /// <param name="innerException">The exception that is the cause of the current exception</param>
        public ApplicationSettingsKeyMissingException(string key, System.Exception innerException)
            : base($"{key} wasn't found within application settings. Please add it", innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSettingsKeyMissingException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">info is null</exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">The class name is null or System.Exception.HResult is zero (0).</exception>
        protected ApplicationSettingsKeyMissingException(
            SerializationInfo info,
            StreamingContext context
        ) : base(info, context)
        {
        }
    }
}
