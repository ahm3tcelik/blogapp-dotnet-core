using System;

namespace BlogApp.Domain
{
	public class UserSocialAccounts: BaseEntity
	{
		public Guid Id { get; set; }
				
		public string? TwitterUsername { get; set; }
		public string? InstagramUserName { get; set; }
		public string? FacebookUsername { get; set; }
		public string? GithubUsername { get; set; }

        public Guid UserId;
        public User? User;
	}
}

