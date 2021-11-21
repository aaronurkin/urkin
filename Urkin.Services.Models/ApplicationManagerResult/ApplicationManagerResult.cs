namespace Urkin.Models
{
    /// <summary>
    /// Provides application manager result
    /// </summary>
    public partial class ApplicationManagerResult
    {
        /// <summary>
        /// Constructor initializes the type of the result
        /// </summary>
        /// <param name="type">The type of a result</param>
        public ApplicationManagerResult(string type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets the result type
        /// </summary>
        public virtual string Type { get; }
    }

    /// <summary>
    /// Provides application manager result extended with data
    /// </summary>
    /// <typeparam name="TData">The data extending an application manager result</typeparam>
    public class ApplicationManagerResult<TData> : ApplicationManagerResult, IDataExtendable
    {
        /// <summary>
        /// The data value
        /// </summary>
        protected readonly TData data;

        /// <summary>
        /// Constructor initializes a succeeded result extended with data
        /// </summary>
        /// <param name="data">The data value to extend result with</param>
        public ApplicationManagerResult(TData data)
            : this(data, SUCCESS)
        {
        }

        /// <summary>
        /// Constructor initializes a typed result extended with data
        /// </summary>
        /// <param name="data">The data value to extend result with</param>
        /// <param name="type">The type of a result</param>
        public ApplicationManagerResult(TData data, string type)
            : base(type)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets data
        /// </summary>
        public virtual object Data => this.data;
    }
}
