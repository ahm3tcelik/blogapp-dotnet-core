using System;
using MediatR;

namespace BlogApp.Application
{
    public record CreatePostCommand(
        string Slug,
        string Article,
        Guid AuthorId) : IRequest<PostDto>;
}

