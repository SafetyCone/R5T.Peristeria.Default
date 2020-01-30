using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Peristeria.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DropboxDirectoryNameConvention"/> implementation of <see cref="IDropboxDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDropboxDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IDropboxDirectoryNameConvention, DropboxDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DropboxDirectoryNameConvention"/> implementation of <see cref="IDropboxDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDropboxDirectoryNameConvention> AddDefaultDropboxDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDropboxDirectoryNameConvention>(() => services.AddDefaultDropboxDirectoryNameConvention());
            return serviceAction;
        }
    }
}
