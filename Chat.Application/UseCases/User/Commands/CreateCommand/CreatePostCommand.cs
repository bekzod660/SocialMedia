using AutoMapper;
using Chat.Application.Abstraction;
using MediatR;

namespace Chat.Application.UseCases.Post.Commands.CreateCommand
{
    public class CreateUserCommand : IRequest<bool>
    {
        public string Name { get; set; }
    }
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IApplicationDbcontext _dbcontext;
        private IMapper _mapper;

        public CreateUserCommandHandler(IApplicationDbcontext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var mappedUser = _mapper.Map<Domain.Entities.User>(request);
            _dbcontext.Users.Add(mappedUser);
            return await _dbcontext.SaveChangesAsync() > 0;
        }
    }
}
