using jienigui.Data;
using jienigui.Models;
using jienigui.Server;
using jienigui.Server.IServer;
using WebApplication1.Config;


namespace jienigui.Server
{
    public class UserServer:IUserServer
    {

        public User userlist()
        {
            UserData userData = new UserData();
            return userData.userList();
        }
    }
}
