﻿using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 301 (moved) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode301MovedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 301 (moved) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 301 (moved)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(301);
        }
    }
}
