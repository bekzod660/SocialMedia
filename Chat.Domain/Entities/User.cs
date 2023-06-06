using Domain.Common;

namespace Chat.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}