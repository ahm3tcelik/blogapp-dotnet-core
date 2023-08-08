using System;
using AutoMapper;
using BlogApp.Domain;

namespace BlogApp.Application.Domain
{
	public class UserMappingProfile : Profile
    {
		public UserMappingProfile()
		{
            CreateMap<User, UserDto>();
            CreateMap<UserSocialAccounts, UserSocialAccountsDto>();
        }
    }
}

