using DataModel.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJewelStore.Repository
{
    public interface IDataRepository
    {
        UserMaster AuthorizeUser(string userName, string encryptPass);
        string GetConfig(string key);
    }
}
