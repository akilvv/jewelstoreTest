using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DataModel.Models.Master;
using DataModel.Models.Enum;
using DataModel.Models.Config;

namespace MyJewelStore.Models
{
    public class AccessModelContextInitilizer: CreateDatabaseIfNotExists<AccessModelContext>
    {

        protected override void Seed(AccessModelContext context)
        {
            IList<UserMaster> userMasters = new List<UserMaster>();

            userMasters.Add(new UserMaster()
            {
                FirstName = "Test1",
                LastName = "User1",
                UserName = "Test1.User1",
                Password = "167d99fdbdd3b221908cc963a306a762",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                UserType = UserType.normalUser,
                ActiveFlag = Status.Active
            });

            userMasters.Add(new UserMaster()
            {
                FirstName = "Test2",
                LastName = "User2",
                UserName = "Test2.User2",
                Password = "167d99fdbdd3b221908cc963a306a762",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                UserType = UserType.privilaged,
                ActiveFlag = Status.Active
            });

            foreach (UserMaster userMaster in userMasters)
                context.userMaster.Add(userMaster);

            IList<ConfigMaster> ConfigMasters = new List<ConfigMaster>();

            ConfigMasters.Add(new ConfigMaster()
            {
                Key = "JewelStore.Discount",
                Value = "10",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                ActiveFlag = Status.Active
            });

            ConfigMasters.Add(new ConfigMaster()
            {
                Key = "JewelStore.EncryptKey",
                Value = "abcde",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                ActiveFlag = Status.Active
            });

            foreach (ConfigMaster configMaster in ConfigMasters)
                context.configMaster.Add(configMaster);

            base.Seed(context);
        }
    }
}