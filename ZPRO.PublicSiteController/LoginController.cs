using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class LoginController : _BaseController
    {
        public LoginController(string connectionString) : base(connectionString) { }

        public void LoginUser(string email, string password)
        {

        }

        public int GetUserIDFromLogin(string email, string password)
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            int result = da.GetUserIDFromLogin(email, password);
            return result;
        }

    }
}
