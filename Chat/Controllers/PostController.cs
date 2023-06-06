using Chat.Application.UseCases.Post.Commands.CreateCommand;
using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostConroller : ApiControllerBase
    {
        //[HttpGet]
        //[Route("[action]")]
        //[OutputCache(Duration = 20)]
        //public async Task<ActionResult<List<GetUserDTO>>> GetAllUsers()
        //{
        //    return await Mediator.Send(new GetAllUsersQuery());
        //}
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<bool>> Create([FromForm] CreatePostCommand commentDTO)
        {
            return await Mediator.Send(commentDTO);
        }
    }
}

