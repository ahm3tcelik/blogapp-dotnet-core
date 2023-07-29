using System;

namespace Domain
{
	public class Comment : BaseEntity
	{
		public Guid Id { get; set; }

		public required string Message { get; set; }

		public required User Author { get; set; }

	}
}

