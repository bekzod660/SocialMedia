using Domain.Common;

namespace Chat.Domain.Entities
{
    public class Post : BaseAuditableEntity
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment>? Comment { get; set; }
    }
}
