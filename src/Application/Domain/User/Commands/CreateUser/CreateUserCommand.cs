using System;
using MediatR;

namespace BlogApp.Application
{
    public record CreateUserCommand(
        string FirstName,
        string LastName,
        string Email,
        UserSocialAccountsDto? SocialAccounts
     ) : IRequest<UserDto>;
}

