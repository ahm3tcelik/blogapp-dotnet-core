using System;
using AutoMapper;
using BlogApp.Application.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            AddCommandHandlers(services);
            AddMappers(services);
            return services;
        }

        private static IServiceCollection AddCommandHandlers(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreatePostCommandHandler).Assembly);
            return services;
        }

        private static IServiceCollection AddMappers(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserMappingProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}

