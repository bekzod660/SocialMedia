using Application.Common.DTOs;
using AutoMapper;
using Chat.Application.UseCases.Post.Commands.CreateCommand;
using Chat.Domain.Entities;

namespace Chat.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {


            Map();
        }
        private void Map()
        {
            CreateMap<User, GetUserDTO>();
            CreateMap<CreateUserCommand, User>();
            CreateMap<Post, GetPostDTO>();
            //  CreateMap<CreatePostCommand, Post>()
            //      .ForMember(x => x.User, y => y.MapFrom(x => x.UserId));

            CreateMap<CreatePostCommand, Post>()
        //.ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignore mapping Id
        // .ForMember(dest => dest.Comment, opt => opt.Ignore()) // Ignore mapping Comment
        .ForMember(dest => dest.User, opt => opt.MapFrom(src => new User { Id = src.UserId }));

            CreateMap<Comment, GetCommentDTO>();
            CreateMap<CreateCommentCommand, Comment>();
        }
    }
}
