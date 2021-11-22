using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

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
        public static IEnumerable<Assembly> GetReferencedAssemblies(this Assembly assembly, IConfiguration configuration)
        {
            string projectNameSeparator = configuration["ProjectNameSeparator"];

            var pattern = string.IsNullOrEmpty(projectNameSeparator)
                ? null
                : assembly.FullName
                    .Substring(0, assembly.FullName.IndexOf(projectNameSeparator, StringComparison.Ordinal));

            var referencedAssemblies = assembly.GetReferencedAssemblies()
                .Where(a => pattern == null || a.FullName.StartsWith(pattern))
                .Select(filteredAssembly => filteredAssembly.FullName)
                .Distinct()
                .SelectMany(name =>
                {
                    var currentAssembly = Assembly.Load(name);
                    return new HashSet<Assembly>(
                        GetReferencedAssemblies(currentAssembly, configuration).Prepend(currentAssembly),
                        new AssemblyEqualityComparer()
                    );
                });

            return referencedAssemblies.Prepend(assembly);
        }
    }
}
