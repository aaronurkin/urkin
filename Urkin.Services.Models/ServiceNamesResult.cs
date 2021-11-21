using System.Collections.Generic;
using System.Linq;

namespace Urkin.Models
{
    /// <summary>
    /// Represents services names result
    /// </summary>
    public class ServiceNamesResult
    {
        /// <summary>
        /// Initializes instance with empty names list
        /// </summary>
        public ServiceNamesResult()
            : this(Enumerable.Empty<string>())
        {
        }

        /// <summary>
        /// Initializes services names
        /// </summary>
        /// <param name="items">Collection of services names</param>
        public ServiceNamesResult(IEnumerable<string> items)
        {
            this.Items = items ?? Enumerable.Empty<string>();
        }

        /// <summary>
        /// Gets services names
        /// </summary>
        public IEnumerable<string> Items { get; }
    }
}
