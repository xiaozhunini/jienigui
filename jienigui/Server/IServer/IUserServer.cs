using jienigui.Models;

namespace jienigui.Server.IServer
{
    public interface IUserServer
    {
        bool login(User user);
        public User userlist();
    }
}
