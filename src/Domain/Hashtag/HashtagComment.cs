using System;

namespace BlogApp.Domain
{
    public class HashtagComment : BaseEntity
    {
        public Guid HashtagId { get; set; }
        public Hashtag Hashtag { get; set; }

        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }

        public ICollection<HashtagComment> Hashtags { get; set; }
    }
}

