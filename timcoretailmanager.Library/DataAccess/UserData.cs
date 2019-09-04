using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timcoretailmanager.Library.Internal.DataAccess;
using timcoretailmanager.Library.Model;

namespace timcoretailmanager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserData(string Id)
        {
            var p = new { Id = Id };

            SqlDataAccess sql = new SqlDataAccess();

            var output =  sql.LoadData<UserModel,dynamic>("dbo.spUserLookup", p, "TRMData");

            return output;
        }
    }
}
