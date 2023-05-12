using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Model;

namespace WelcomeExtened.Data
{
    public class UserData
    {
       public List<User> _users;
       public int _nextId;

        public UserData()
        {
            _nextId = 0;
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Append(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return true;
                }

            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Name == name && x.Password == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Name == name && user.Password == password
                      select user.Id;
            return ret != null ? true : false;
        }

        public string GetUser(string name, string password)
        {
            foreach( var user in _users)
            {
                if ( user.Name.Equals(name) || user.Password.Equals(password))
                {
                    return user.Name;
                }
            }

            return "Not";
            
        }

        public void AssignUserRole(string name, UserRolesEnums enum1)
        {
           foreach( var user in _users)
            {
                if (user.Name.Equals(name))
                {
                    user.Role = enum1;
                }
            }
        }

           public void SetActive(string name, DateTime date)
            {
                foreach ( var user in _users)
                {
                  if (user.Name.Equals(name))
                  {
                    user.Expires = date;
                  }
            }
            }
    }
}

 