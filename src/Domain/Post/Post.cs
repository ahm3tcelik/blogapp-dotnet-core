using System;

namespace Domain
{
	public class Post : BaseEntity
	{
        public Guid Id { get; set; }

        public required string Slug { get; set; }

        public required string Article { get; set; }

        public required User Author { get; set; }

    }
}