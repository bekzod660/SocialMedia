using Application.Common.DTOs;
using AutoMapper;
using Chat.Application.Abstraction;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Chat.Application.UseCases.User.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<GetUserDTO>>
    {
    }
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<GetUserDTO>>
    {
        private readonly IApplicationDbcontext _db;

        private IMapper mapper;
        public GetAllUsersQueryHandler(IApplicationDbcontext db, IMapper mapper)
        {
            _db = db;
            this.mapper = mapper;
        }

        public async Task<List<GetUserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.User> res = _db.Users.Include(x => x.Posts)
                .ThenInclude(y => y.Comment)
                .ThenInclude(z => z.Replies).ToList();

            List<GetUserDTO> result = mapper.Map<List<GetUserDTO>>(res);
            return await Task.FromResult(result);
        }
    }
}
