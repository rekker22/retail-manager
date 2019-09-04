using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using timcoretailmanager.Library.DataAccess;
using timcoretailmanager.Library.Model;

namespace timcoretailmanager.Controllers
{
    [System.Web.Http.Authorize]
    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            var userid = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserData(userid);
        }
    }
}
