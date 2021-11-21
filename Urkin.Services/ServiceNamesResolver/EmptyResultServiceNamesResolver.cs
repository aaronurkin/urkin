using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Services
{
    /// <summary>
    /// Empty names collection implementation of the <see cref="IServiceNamesResolver"/>
    /// </summary>
    public class EmptyResultServiceNamesResolver : IServiceNamesResolver
    {
        /// <summary>
        /// Resolves services names
        /// </summary>
        /// <returns>The empty instance of the <see cref="ServiceNamesResult"/></returns>
        public Task<ServiceNamesResult> Resolve()
        {
            return Task.FromResult(new ServiceNamesResult());
        }
    }
}
