using System;
using BlogApp.Application;
using MediatR;

namespace BlogApp.Application
{
    public record GetUserQuery(string Id) : IRequest<UserDto>;
}