using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJewelStore.Common
{
    public interface IHelper
    {
        string Encrypt(string passWord, string EncKey);
    }
}
