using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ModulSchool.Application;
using ModulSchool.Models;

namespace ModulSchool.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly GetUsersInfoRequestHandler _getUsersInfoRequestHandler;

        public UsersController(GetUsersInfoRequestHandler getUsersInfoRequestHandler)
        {
            _getUsersInfoRequestHandler = getUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<User> GetUserInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }
    }

}
