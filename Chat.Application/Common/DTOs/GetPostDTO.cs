

namespace Application.Common.DTOs
{
    public class GetPostDTO
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public ICollection<GetCommentDTO> Comments { get; set; }
    }
}
