using System;
using Application.Domain;
using Domain;

namespace Persistence.Domain
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
	}
}

