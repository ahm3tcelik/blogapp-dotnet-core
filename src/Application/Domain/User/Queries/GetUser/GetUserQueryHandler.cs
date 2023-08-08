using System;
using MediatR;
using BlogApp.Application.Domain;
using BlogApp.Domain;
using AutoMapper;

namespace BlogApp.Application
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public GetUserQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByAsync(user => user.PublicId == new Guid(request.Id));
            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}

