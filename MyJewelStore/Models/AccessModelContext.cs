using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DataModel.Models.Master;
using DataModel.Models.Config;

namespace MyJewelStore.Models
{
    public class AccessModelContext:DbContext
    {
        public AccessModelContext() : base("name=AccessModelContext")
        {           
        }
        public DbSet<UserMaster> userMaster { get; set; }
        public DbSet<ConfigMaster> configMaster { get; set; }
    }
}