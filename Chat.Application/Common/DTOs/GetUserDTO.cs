namespace Application.Common.DTOs
{
    public class GetUserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetPostDTO> Posts { get; set; }
    }
}
