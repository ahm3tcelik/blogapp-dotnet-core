using System;

namespace BlogApp.Domain
{
	public class HashtagPost : BaseEntity
	{
		public Guid HashtagId { get; set; }
		public required Hashtag Hashtag { get; set; }

		public Guid PostId { get; set; }
		public required Post Post { get; set; }
	}
}

