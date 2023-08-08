using System;
using BlogApp.Domain;

namespace BlogApp.Infrastructure.Persistence.Domain
{
    public class HashtagRepository : GenericRepository<Hashtag>, IHashtagRepository
    {
        public HashtagRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

