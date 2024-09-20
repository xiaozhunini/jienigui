using jienigui.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using WebApplication1.Config;

namespace jienigui.Data
{
    public class UserData
    {
        private readonly SQLHelper sqlHelper;
        StringBuilder sb = new StringBuilder();

        public UserData()
        {
            sqlHelper = new SQLHelper();
        }
        public User userList()
        {
            sb.Clear();
            sb.AppendLine("select * from db_user;");
            sb.AppendLine();

            sqlHelper.Open();
            DataTable dataTable = sqlHelper.ExecuteDataTable(sb.ToString());
            
            List<User> users = new List<User>();    
            foreach (DataRow row in dataTable.Rows)
            {
                User user = new User();
                user.Id = (int)row["Id"];
                user.UserName = (string)row["UserName"];
                user.Password = (string)row["Password"];
                user.UserId = (int)row["UserId"];
                users.Add(user);
            }



            return new User();
        }

        internal bool login(User user)
        {
            sb.Clear();
            sb.AppendLine($"select * from db_user where username='{user.UserName}' and password='{user.Password}';");
            sqlHelper.Open();
            DataTable dataTable = sqlHelper.ExecuteDataTable(sb.ToString());

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            };

        }
    }
}
