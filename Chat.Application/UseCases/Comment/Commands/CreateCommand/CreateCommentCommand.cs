using AutoMapper;
using Chat.Application.Abstraction;
using Chat.Domain.Entities;
using MediatR;

namespace Chat.Application.UseCases.Post.Commands.CreateCommand
{
    public class CreateCommentCommand : IRequest<bool>
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
    }
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, bool>
    {
        private readonly IApplicationDbcontext _dbcontext;
        private IMapper _mapper;

        public CreateCommentCommandHandler(IApplicationDbcontext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            Comment comment = new Comment()
            {
                Id = new Guid(),
                Text = request.Text,
                UserId = request.UserId,
                PostId = (Guid)request.PostId,
                CommentId = (Guid)request.CommentId
            };
            Console.WriteLine();
            _dbcontext.Comments.Add(comment);
            //  await _dbcontext.SaveChangesAsync();
            return await _dbcontext.SaveChangesAsync() > 0;
        }
    }
}
