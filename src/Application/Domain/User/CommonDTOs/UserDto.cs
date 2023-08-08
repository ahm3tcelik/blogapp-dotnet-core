using System;
using BlogApp.Domain;

namespace BlogApp.Application
{
	public class UserDto
	{
        public required string PublicId { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public UserSocialAccountsDto? socialAccounts { get; set; }
    }
}

