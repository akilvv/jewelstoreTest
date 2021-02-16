using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyJewelStore.Models;
using log4net;
using DataModel.Models.Master;
using DataModel.Models.Enum;
using DataModel.Models.Config;

namespace MyJewelStore.Repository
{
    public class DataRepository: IDataRepository
    {
        private AccessModelContext db = new AccessModelContext();

        public UserMaster AuthorizeUser(string userName, string encryptPass)
        {
            UserMaster user = new UserMaster();
            try
            {
                user = db.userMaster.Where(a => a.UserName == userName && a.Password == encryptPass && a.ActiveFlag == Status.Active).SingleOrDefault();               
            }
            catch(Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return user;
        }

        public string GetConfig(string key)
        {
            string value = string.Empty;
            try
            {
                ConfigMaster config = db.configMaster.Where(a => a.Key == key).FirstOrDefault();
                if (config != null)
                    value = config.Value;
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return value;
        }



       




    }
}