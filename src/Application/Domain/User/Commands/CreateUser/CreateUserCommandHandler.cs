using System;
using MediatR;
using BlogApp.Application.Domain;
using BlogApp.Domain;
using AutoMapper;

namespace BlogApp.Application
{
    public class CreatePostCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public CreatePostCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                SocialAccounts = getUserSocialAccountEntity(request.SocialAccounts),
            };
            user = await userRepository.AddAsync(user);
            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }

        private UserSocialAccounts? getUserSocialAccountEntity(UserSocialAccountsDto? dto)
        {
            if (dto != null)
            {
                UserSocialAccounts socialAccounts = new()
                {
                    TwitterUsername = dto.TwitterUsername,
                    FacebookUsername = dto.FacebokoUsername,
                    GithubUsername = dto.GithubUsername,
                    InstagramUserName = dto.InstagramUsername,
                };
                return socialAccounts;
            }
            return null;
        }
    }
}

