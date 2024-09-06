using Microsoft.AspNetCore.Mvc;
using jienigui.Server.IServer;
using jienigui.Models;

namespace jienigui.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserServer UserServer;
        public UserController(IUserServer userServer) {
            UserServer = userServer;
        }


        [HttpGet]
        public ActionResult<User> userlist()
        {
            return UserServer.userlist();
        }
        [HttpGet]
        public ActionResult<List<User>> text()
        {
            List<User> list = new List<User>();
            list.Add(new User()
            {
                Id = 1,
                UserName = "Test",
                Password = "Test",
                UserId = 1
            });
            list.Add(new User()
            {
                Id = 2,
                UserName = "Test1",
                Password = "Test1",
                UserId = 2
            });
            return list;
        }
    }
}
