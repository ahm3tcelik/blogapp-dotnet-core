using System;
using BlogApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Persistence
{
    public class HashtagPostEntityTypeConfiguration : IEntityTypeConfiguration<HashtagPost>
    {
        public void Configure(EntityTypeBuilder<HashtagPost> builder)
        {
            builder
                .HasKey(hashtagPost => new { hashtagPost.HashtagId, hashtagPost.PostId });

            builder
                .HasOne(hashtagPost => hashtagPost.Post)
                .WithMany(post => post.Hashtags);
        }
    }
}

