using AutoMapper;
using Chat.Application.Abstraction;

namespace Chat.Application.UseCases
{
    internal abstract class BaseCase
    {
        private readonly IApplicationDbcontext _dbcontext;
        private IMapper _mapper;

        public BaseCase(IApplicationDbcontext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
    }
}
