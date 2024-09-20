using jienigui.Server.IServer;
using Microsoft.AspNetCore.Mvc;

namespace jienigui.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TagController : Controller
    {
        public readonly ITagServer tagServer;
        public TagController(ITagServer _tagServer)
        {
            tagServer = _tagServer;
        }
        #region 增加
        #endregion
        #region 删除
        #endregion
        #region 修改
        #endregion
        #region 查询
        #endregion



    }
}
