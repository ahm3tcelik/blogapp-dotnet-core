using System;
using BlogApp.Domain;

namespace BlogApp.Infrastructure.Persistence.Domain
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

