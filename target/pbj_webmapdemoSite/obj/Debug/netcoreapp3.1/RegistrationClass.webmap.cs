#pragma warning disable
#line 1 "RegistrationClass.cs"
#pragma warning disable
#line 1 "RegistrationClass.cs"
namespace WebSite
{
    using System.Collections.Generic;
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Mobilize.Web;
    using Mobilize.Web.Wrappers;
    using Mobilize.WebMap.Common.Core;
    using Mobilize.WebMap.Common.Core.ObservableWrapper;
    using Mobilize.WebMap.Common.Messaging;
    using Mobilize.WebMap.Core.ObservableWrapper;
    using Mobilize.WebMap.Messaging;

    /// <summary>
    /// Registration for Wrappers and Mappers
    /// </summary>
    public static partial class RegistrationClass
    {
        private static List<Assembly> assembliesForRegistrations = AssemblyRegistration.GetAssembliesForRegistration(Assembly.GetEntryAssembly());

        /// <summary>
        /// Registers the model projectors.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterModelMappers(this IServiceCollection services)
        {
            services.AddSingleton<IMapperCatalog>((provider) =>
            {
                var logger = provider.GetService<ILoggerFactory>();
                var service = new MapperCatalog(logger);
                //service.AddMapperFactory(new DefaultMapperFactory());

                // register mappers from Assemblies for registration (it includes current Assembly)
                AssemblyRegistration.RegisterMappers(assembliesForRegistrations, logger.CreateLogger("Information"), service);

                return service;
            });
        }

        /// <summary>
        /// Registers the wrappers.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterWrappers(this IServiceCollection services)
        {
            services.AddSingleton<IObservableWrapperCatalog>(
              (provider) =>
              {
                  var catalog = new ObservableWrapperCatalog();
                  catalog.Register(typeof(ListWrapper<Window>), typeof(List<Window>));
                  // register wrappers from referenced Assemblies
                  AssemblyRegistration.RegisterWrappers(assembliesForRegistrations, catalog);

                  // assembliesForRegistrations is not longer required, so is cleared out.
                  assembliesForRegistrations.Clear();
                  assembliesForRegistrations = null;
                  return catalog;
              });
        }
    }
}


#pragma warning restore
