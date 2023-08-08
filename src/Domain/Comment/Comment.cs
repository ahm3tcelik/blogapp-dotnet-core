using System;

namespace BlogApp.Domain
{
	public class Comment : BaseEntity
	{
		public Guid Id { get; set; }

		public string Message { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public ICollection<HashtagComment> Hashtags { get; set; }

    }
}

