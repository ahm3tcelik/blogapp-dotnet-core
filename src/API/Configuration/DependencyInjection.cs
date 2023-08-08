using System;
using BlogApp.Application;
using BlogApp.Infrastructure.Persistence;
using BlogApp.Infrastructure.Persistence.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.API.Configuration
{
	public static class DependencyInjection
	{
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddLayers(services);
            return services;
        }

        private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("BlogApp"));
            //var connectionString = configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }

        private static IServiceCollection AddLayers(this IServiceCollection services)
		{
            PersistenceDependencyInjection.Register(services);
            ApplicationDependencyInjection.Register(services);
			return services;
		}
    }
}

