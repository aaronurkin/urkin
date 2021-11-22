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
        /// Finds all referenced assemblies of the specified assembly
        /// </summary>
        /// <param name="source">An assembly to find referenced assemblies</param>
        /// <param name="configuration">Application configuration containing project name separator value with the 'ProjectNameSeparator' key</param>
        /// <returns>A <see cref="IEnumerable{Assembly}"/> that contains referenced assemblies</returns>
        public static IEnumerable<Assembly> GetReferencedAssemblies(this Assembly source, IConfiguration configuration)
        {
            var processed = new HashSet<string>();
            var assemblies = new Queue<Assembly>(new[] { source });
            string projectNameSeparator = configuration["ProjectNameSeparator"];

            var pattern = string.IsNullOrEmpty(projectNameSeparator)
                ? null
                : source.FullName
                    .Substring(0, source.FullName.IndexOf(projectNameSeparator, StringComparison.Ordinal));

            while (assemblies.Any())
            {
                var assembly = assemblies.Dequeue();

                if (processed.Add(assembly.FullName))
                {
                    var references = assembly.GetReferencedAssemblies()
                        .Where(a => !a.FullName.StartsWith("Urkin."))
                        .Where(a => !a.FullName.StartsWith("System."))
                        .Where(a => !a.FullName.StartsWith("Microsoft."))
                        .Where(a => !a.FullName.StartsWith("netstandard"))
                        .Where(a => pattern == null || a.FullName.StartsWith(pattern))
                        .Select(a => a.FullName)
                        .Distinct();

                    foreach (var reference in references)
                    {
                        assemblies.Enqueue(Assembly.Load(reference));
                    }

                    yield return assembly;
                }
            }

            processed.Clear();
        }
    }
}
