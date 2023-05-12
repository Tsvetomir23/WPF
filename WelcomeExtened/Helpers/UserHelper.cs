using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Model;
using WelcomeExtened.Data;

namespace WelcomeExtened.Helpers
{
    public static class UserHelper
    {

        public static string MyString(this UserData users)
        {

            return users.MyString();

        }

        public static bool ValidateCredentials(this UserData users, string name, string password)
        {
            return users.ValidateUser(name, password);
        }

        public static string GetUser (this  UserData users, string username, string password)
        {
            return users.GetUser(username, password); 
        }
    }
}
