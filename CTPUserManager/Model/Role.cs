using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPUserManager.Model
{
    public class Role
    {
        private string id;
        private string name;
        public string Id
        {
            get => id;
            set => id = value;
        }

        private string Name
        {
            get => name;
            set => name = value;
        }


    }
}
