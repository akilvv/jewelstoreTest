using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Models.Enum;

namespace DataModel.Models.Master
{

    [Table("UserMaster")]
    public class UserMaster
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserType UserType { get; set; } = UserType.normalUser;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Status ActiveFlag { get; set; } = Status.Active;
    }
}
