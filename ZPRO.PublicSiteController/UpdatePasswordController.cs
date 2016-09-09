using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.SQLDBDataAccess;
using ZPRO.Model;

namespace ZPRO.PublicSiteController
{
    public class UpdatePasswordController : _BaseController
    {
        public UpdatePasswordController(string connectionString) : base(connectionString) { }

        public int GetUserIDFromPassword(string password)
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            int userID = da.GetUserIDFromPassword(password);
            return userID;
        }

        public void UpdatePassword(UserModel um)
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            da.UpdatePassword(um);
        }
    }
}
