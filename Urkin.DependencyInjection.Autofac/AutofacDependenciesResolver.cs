using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using System.Collections.Generic;
using System.Linq;

namespace Urkin.DependencyInjection.Autofac
{
    /// <summary>
    /// Provides actions to resolve application dependencies using Autofac IoC container 
    /// </summary>
    public class AutofacDependenciesResolver : IDependenciesResolver
    {
        private readonly ILifetimeScope lifetimeScope;

        /// <summary>
        /// Constructor initializes <see cref="ILifetimeScope"/> parameter
        /// </summary>
        /// <param name="lifetimeScope">The <see cref="ILifetimeScope"/> parameter</param>
        public AutofacDependenciesResolver(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope ?? throw new System.ArgumentNullException(nameof(lifetimeScope));
        }

        /// <summary>
        /// Retrieves a service from the DI container by a key
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="constructorArguments">Constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        /// <exception cref="DependencyResolutionException"></exception>
        /// <exception cref="ComponentNotRegisteredException"></exception>
        public virtual TService Resolve<TService>(params object[] constructorArguments)
            where TService : class
        {
            if (constructorArguments?.Any() ?? false)
            {
                var typedParameters = this.ResolveParameters(constructorArguments);
                return this.lifetimeScope.Resolve<TService>(typedParameters);
            }

            return this.lifetimeScope.Resolve<TService>();
        }

        /// <summary>
        /// Retrieves a service from the DI container by a key
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="constructorArguments">The first argument is a key of the service. Other argument are constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        /// <exception cref="DependencyResolutionException"></exception>
        /// <exception cref="ComponentNotRegisteredException"></exception>
        public virtual TService ResolveKeyed<TService>(params object[] constructorArguments)
            where TService : class
        {
            if (constructorArguments == null)
            {
                throw new System.ArgumentNullException(nameof(constructorArguments));
            }

            if (constructorArguments.Length < 1)
            {
                throw new System.ArgumentException("At least one parameter must be passed", nameof(constructorArguments));
            }

            var key = constructorArguments[0];

            if (constructorArguments.Length > 1)
            {
                var typedParameters = this.ResolveParameters(constructorArguments.Skip(1));
                return this.lifetimeScope.ResolveKeyed<TService>(key, typedParameters);
            }

            return this.lifetimeScope.ResolveKeyed<TService>(key);
        }

        /// <summary>
        /// Retrieves a service from the DI container by the first appearance of a name from the names parameter 
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="names">Collection of names to retrieve a service by</param>
        /// <param name="constructorArguments">Constructor arguments</param>
        /// <returns>The component instance that provides the service</returns>
        /// <exception cref="DependencyResolutionException"></exception>
        /// <exception cref="ComponentNotRegisteredException"></exception>
        public virtual TService ResolveNamed<TService>(IEnumerable<string> names, params object[] constructorArguments)
            where TService : class
        {
            if (names == null)
            {
                throw new System.ArgumentNullException(nameof(names));
            }

            TService service;
            var typedParameters = this.ResolveParameters(constructorArguments);

            foreach (var name in names)
            {
                service = !typedParameters.Any()
                    ? this.lifetimeScope.ResolveOptionalNamed<TService>(name)
                    : this.lifetimeScope.ResolveOptionalNamed<TService>(name, typedParameters);

                if (service != null)
                {
                    return service;
                }
            }

            return this.Resolve<TService>(constructorArguments);
        }

        /// <summary>
        /// Retrieves all implementations of a service from the DI container
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <returns>The collection of the service instances</returns>
        public virtual IEnumerable<TService> ResolveAll<TService>()
        {
            return this.Resolve<IEnumerable<TService>>();
        }

        /// <summary>
        /// Retrieves all implementations of a service from the DI container by a key
        /// </summary>
        /// <typeparam name="TService">The type to which the result will be cast</typeparam>
        /// <param name="key">The key to retrieve a service by</param>
        /// <returns>The collection of the service instances</returns>
        public IEnumerable<TService> ResolveAllKeyed<TService>(object key)
        {
            return this.ResolveKeyed<IEnumerable<TService>>(key);
        }

        /// <summary>
        /// Retrieves all implementations of a service from the DI container by the first appearance of a name from the names parameter 
        /// </summary>
        /// <typeparam name="TService">The type to which the service will be cast</typeparam>
        /// <param name="names">Collection of names to retrieve a service by</param>
        /// <returns>The collection of the service instances</returns>
        public IEnumerable<TService> ResolveAllNamed<TService>(params string[] names)
        {
            return this.ResolveNamed<IEnumerable<TService>>(names);
        }

        private IEnumerable<TypedParameter> ResolveParameters(IEnumerable<object> constructorArguments)
        {
            return constructorArguments?
                .Where(parameter => parameter != null)
                .Select(parameter => new TypedParameter(parameter.GetType(), parameter));
        }
    }
}
