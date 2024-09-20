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
        public UserController(IUserServer userServer)
        {
            UserServer = userServer;
        }



        #region 增加
        #endregion
        #region 删除
        #endregion
        #region 修改
        #endregion
        #region 查询

        [HttpGet]
        public ActionResult<string> login(string username, string password)
        {
            if (username == null || password == null)
            {
                return "账户密码不能为空";
            }
            else
            {
                User user = new User();
                user.UserName = username;
                user.Password = password;
                if (UserServer.login(user))
                {
                    return Ok();
                }
            };
            return NotFound();
        }

        [HttpGet]
        public ActionResult<User> userList()
        {
            return UserServer.userlist();
        }

        #endregion
    }



}

