using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;

namespace ZPRO.PublicSiteController
{
    public class UpdateUserController : _BaseController
    {
        public UpdateUserController(string connectionString) : base(connectionString) { }


        public void UpdateUser(UserModel um)
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            da.UpdateUser(um);
        }

        public List<UserModel> GetUsers()
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            return da.GetUsers();
        }
    }
}
