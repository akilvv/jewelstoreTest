using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyJewelStore.BusinessLogic
{
    public interface IAuthService
    {
        Dictionary<string, string> AuthorizeUser(string userName, string password);
       
    }
}