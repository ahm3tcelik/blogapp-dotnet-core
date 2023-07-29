using System;
using Application.Domain;
using Domain;

namespace Persistence.Domain
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
	}
}

