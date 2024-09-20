using jienigui.Server.IServer;
using Microsoft.AspNetCore.Mvc;

namespace jienigui.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AmountController : Controller
    {
        public readonly IAmountServer amountServer;
        public AmountController(IAmountServer _amountServer)
        {
            amountServer = _amountServer;
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
