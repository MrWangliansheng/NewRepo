using INewRepoDAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepoDAL;
using NewRepoModel;

namespace NewRepoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly UserRepository dal;
        public UserController(UserRepository dal)
        {
            this.dal = dal;
        }

        [HttpGet("UserLog")]
        public Task<User>  UserLog(string name,string pwd)
        {
            var user=dal.UserLog(name, pwd);
            return  user;
        }
    }
}
