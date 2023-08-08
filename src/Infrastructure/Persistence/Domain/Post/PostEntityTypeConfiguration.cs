using System;
using BlogApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Persistence
{
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(post => post.Author)
                .WithMany(author => author.Posts)
                .HasForeignKey(post => post.AuthorId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}

