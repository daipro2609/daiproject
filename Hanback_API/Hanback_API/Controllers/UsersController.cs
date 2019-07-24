using Hanback.DAL.EF;
using Hanback.Service.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hanback_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userSer)
        {
            _userService = userSer;
        }
        // GET: api/Users
        [HttpGet]
        public string Get()
        {
            return "Welcome to Atman";
        }


        // POST: api/Users
        [HttpPost]
        [Route("login")]
        public ActionResult Login([FromBody] HpMasUser user)
        {
            return Ok(_userService.Login(user));
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("update")]
        public void updateUser(int id)
        {

        }
    }
}
