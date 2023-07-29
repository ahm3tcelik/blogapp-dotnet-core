using System;
using Application.Domain;
using Domain;

namespace Persistence.Domain
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
	}
}

