using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin.Model
{
    public class User
    {
        public string Name { get ; set; }

        virtual public int Id { get; set; }
        public string Password { get; set; }

        public DateTime Expires { get; set; }
        public UserRolesEnums  Role { get; set; }
    }
}
