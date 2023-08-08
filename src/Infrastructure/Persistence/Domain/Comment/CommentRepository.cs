using System;
using BlogApp.Domain;

namespace BlogApp.Infrastructure.Persistence.Domain
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

