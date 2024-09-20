using jienigui.Server.IServer;
using Microsoft.AspNetCore.Mvc;

namespace jienigui.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NoteController : Controller
    {
        public readonly INoteServer noteServer;

        public NoteController(INoteServer _noteServer)
        {
            noteServer = _noteServer;
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
