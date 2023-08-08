using System;
using BlogApp.Domain;

namespace BlogApp.Infrastructure.Persistence.Domain
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

