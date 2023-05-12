using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Model;

namespace UserLogin.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user) {
            _user = user;
        }

        public string Name {
            get { return _user.Name; }
            set { _user.Name = value; }
        }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public UserRolesEnums Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }
    }
}
