using System;

namespace BlogApp.Domain
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }

        public Guid PublicId { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public Guid? SocialAccountId { get; set; }
        public UserSocialAccounts? SocialAccounts { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}

