using System.Collections.Generic;

namespace System.Reflection
{
    /// <summary>
    /// Encapsulates methods to support the comparison of assemblies for equality.
    /// </summary>
    public class AssemblyEqualityComparer : IEqualityComparer<Assembly>
    {
        /// <summary>
        /// Determines whether the specified assemblies are equal.
        /// </summary>
        /// <param name="first">The first assembly to compare.</param>
        /// <param name="second">The second assembly to compare.</param>
        /// <returns>true if the specified assemblies are equal; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">Throws if one of the specified assemblies is null</exception>
        public bool Equals(Assembly first, Assembly second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return string.Equals(first.FullName, second.FullName);
        }

        /// <summary>
        /// Returns a hash code for the specified assembly.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> for which a hash code is to be returned.</param>
        /// <returns>A hash code for the specified assembly.</returns>
        public int GetHashCode(Assembly assembly)
        {
            return assembly.FullName.GetHashCode();
        }
    }
}
