using System.Collections.Generic;

namespace Urkin.DependencyInjection
{
    /// <summary>
    /// Provides actions to resolve application dependencies
    /// </summary>
    public interface IDependenciesResolver
    {
        /// <summary>
        /// Retrieves a service from the DI container
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="constructorArguments">Constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        TService Resolve<TService>(params object[] constructorArguments) where TService : class;

        /// <summary>
        /// Retrieves a service from the DI container by a key
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="constructorArguments">The first argument is a key of the service. Other argument are constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        TService ResolveKeyed<TService>(params object[] constructorArguments) where TService : class;

        /// <summary>
        /// Retrieves a service from the DI container by the first appearance of a name from the names parameter 
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="names">Collection of names to retrieve a service by</param>
        /// <param name="constructorArguments">Constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        TService ResolveNamed<TService>(IEnumerable<string> names, params object[] constructorArguments) where TService : class;

        /// <summary>
        /// Retrieves all implementations of a service from the DI container
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <returns>The collection of the service instances</returns>
        IEnumerable<TService> ResolveAll<TService>();

        /// <summary>
        /// Retrieves all implementations of a service from the DI container by a key
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="key">The key to retrieve a service by</param>
        /// <returns>The collection of the service instances</returns>
        IEnumerable<TService> ResolveAllKeyed<TService>(object key);

        /// <summary>
        /// Retrieves all implementations of a service from the DI container by the first appearance of a name from the names parameter 
        /// </summary>
        /// <typeparam name="TService">The type to which the service will be cast</typeparam>
        /// <param name="names">Collection of names to retrieve a service by</param>
        /// <returns>The collection of the service instances</returns>
        IEnumerable<TService> ResolveAllNamed<TService>(params string[] names);
    }
}
