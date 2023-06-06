using Application.Common.DTOs;
using Chat.Application.UseCases.Post.Commands.CreateCommand;
using Chat.Application.UseCases.User.Queries.GetAllUsers;
using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace Chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        [OutputCache(Duration = 20)]
        public async Task<ActionResult<List<GetUserDTO>>> GetAllUsers()
        {
            return await Mediator.Send(new GetAllUsersQuery());
        }

        [HttpPost]
        [Route("[action]")]
        [OutputCache(Duration = 20)]
        public async Task<ActionResult<bool>> Create([FromForm] CreateUserCommand user)
        {
            return await Mediator.Send(user);
        }
    }
}

