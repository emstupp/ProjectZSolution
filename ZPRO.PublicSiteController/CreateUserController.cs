using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPRO.Model;
using ZPRO.SQLDBDataAccess;
using ZPRO.SQLEntityORM;

namespace ZPRO.PublicSiteController
{
    public class CreateUserController : _BaseController
    {
        public CreateUserController(string connectionString) : base(connectionString) { }

        public void InsertUser(UserModel newUser)
        {
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);
            UserORM oda = new UserORM();
            if (!da.EmailAddressAlreadyExists(newUser.Email))
            {
                da.InsertUser(newUser);                
            }
        }
    }
}
