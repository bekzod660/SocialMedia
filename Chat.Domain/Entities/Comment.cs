using Domain.Common;

namespace Chat.Domain.Entities
{
    public class Comment : BaseAuditableEntity
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public Guid CommentId { get; set; }
        public Comment? Comments { get; set; }

        public ICollection<Comment>? Replies { get; set; }
    }
}