using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Urkin.Exceptions;

namespace System.Reflection
{
    /// <summary>
    /// Provides a set of static methods extending the <see cref="Assembly"/> class
    /// </summary>
    public static partial class AssemblyExtensions
    {
        /// <summary>
        /// Recursively finds all referenced assemblies of the specified assembly
        /// </summary>
        /// <param name="assembly">An assembly to find referenced assemblies</param>
        /// <param name="configuration">Application configuration containing project name separator value</param>
        /// <returns>A <see cref="IEnumerable{Assembly}"/> that contains referenced assemblies</returns>
        /// <exception cref="ApplicationSettingsKeyMissingException"></exception>
        public static IEnumerable<Assembly> GetReferencedAssemblies(this Assembly assembly, IConfiguration configuration)
        {
            const string PROJECT_NAME_SEPARATOR_KEY = "ProjectNameSeparator";
            string projectNameSeparator = configuration[PROJECT_NAME_SEPARATOR_KEY];

            if (string.IsNullOrEmpty(projectNameSeparator))
            {
                throw new ApplicationSettingsKeyMissingException(PROJECT_NAME_SEPARATOR_KEY);
            }

            var assemblies = new List<Assembly>();
            var pattern = assembly.FullName
                .Substring(0, assembly.FullName.IndexOf(projectNameSeparator, StringComparison.Ordinal));

            var referencedAssemblies = assembly.GetReferencedAssemblies()
                .Where(referencedAssembly => referencedAssembly.FullName.StartsWith(pattern))
                .Select(filteredAssembly => filteredAssembly.FullName)
                .Distinct()
                .Select(a => Assembly.Load(a));

            assemblies.AddRange(referencedAssemblies);

            foreach (Assembly referencedAssembly in referencedAssemblies)
            {
                assemblies.AddRange(GetReferencedAssemblies(referencedAssembly, configuration));
            }

            return assemblies.Distinct();
        }
    }
}
