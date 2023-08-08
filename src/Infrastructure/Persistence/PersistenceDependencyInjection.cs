using System;
using BlogApp.Domain;
using BlogApp.Infrastructure.Persistence.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Infrastructure.Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            AddRepositories(services);
            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            return services;
        }
	}
}

