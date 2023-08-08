using System;
using BlogApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Persistence
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
               .HasOne(user => user.SocialAccounts)
               .WithOne(socialAccounts => socialAccounts.User)
               .HasForeignKey<UserSocialAccounts>(socialAccount => socialAccount.UserId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

