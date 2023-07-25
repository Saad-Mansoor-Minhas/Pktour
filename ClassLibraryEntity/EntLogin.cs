using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntLogin
    {
        public int pk_LoginId { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


    }
}
