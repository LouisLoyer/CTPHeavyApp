using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPUserManager.Model
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        private string token1;

        public string Gettoken()
        {
            return token1;
        }

        public void Settoken(string value)
        {
            token1 = value;
        }
    }
}
