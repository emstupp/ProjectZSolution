using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class UserListController : _BaseController
    {
        public UserListController(string connectionString) : base(connectionString) { }

        public List<UserModel> GetUsers()
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            List<UserModel> result = da.GetUsers();
            return result;
        }
    }
}
