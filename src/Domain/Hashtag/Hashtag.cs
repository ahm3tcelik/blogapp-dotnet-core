using System;
namespace BlogApp.Domain
{
	public class Hashtag : BaseEntity
	{
		public Guid Id { get; set; }

		public String Name { get; set; }

		public User CreatedBy { get; set; }

		public IEnumerable<Post> Posts { get; set; }

		public IEnumerable<Comment> Comments { get; set; }
	}
}

