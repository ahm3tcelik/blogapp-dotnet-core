using System;

namespace BlogApp.Domain
{
	public class Post : BaseEntity
	{
        public Guid Id { get; set; }

        public Guid PublicId { get; set; }

        public string Slug { get; set; }

        public string Article { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<HashtagPost> Hashtags { get; set; }
    }
}