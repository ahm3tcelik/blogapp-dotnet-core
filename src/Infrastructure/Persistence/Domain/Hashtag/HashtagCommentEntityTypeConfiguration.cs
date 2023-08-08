using System;
using BlogApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Persistence
{
    public class HashtagCommentEntityTypeConfiguration : IEntityTypeConfiguration<HashtagComment>
    {
        public void Configure(EntityTypeBuilder<HashtagComment> builder)
        {
            builder
             .HasKey(comment => new { comment.HashtagId, comment.CommentId });

            builder
                .HasOne(hashtagComment => hashtagComment.Comment)
                .WithMany(comment => comment.Hashtags);
        }
    }
}

