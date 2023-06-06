using AutoMapper;
using Chat.Application.Abstraction;
using MediatR;

namespace Chat.Application.UseCases.Post.Commands.CreateCommand
{
    public class CreatePostCommand : IRequest<bool>
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }
    }
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, bool>
    {
        private readonly IApplicationDbcontext _dbcontext;
        private IMapper _mapper;

        public CreatePostCommandHandler(IApplicationDbcontext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            // var mappedPost = _mapper.Map<Domain.Entities.Post>(request);
            Domain.Entities.Post mappedPost = new Domain.Entities.Post
            {
                Text = request.Text,
                UserId = request.UserId
            };

            _dbcontext.Posts.Add(mappedPost);
            return await _dbcontext.SaveChangesAsync() > 0;
        }
    }
}
