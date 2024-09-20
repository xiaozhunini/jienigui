using jienigui.Server.IServer;
using Microsoft.AspNetCore.Mvc;

namespace jienigui.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MoneyController : Controller
    {
        public readonly IMoneyServer moneyServer;
        public MoneyController(IMoneyServer _moneyServer)
        {
            moneyServer = _moneyServer;
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
