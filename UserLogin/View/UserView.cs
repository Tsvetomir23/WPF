using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.ViewModel;
using UserLogin.Model;

namespace UserLogin.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel) {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome\n" + "User: " + _viewModel.Name + "\nRole: " + _viewModel.Role);
        }

        public void DisplayError()
        {
            throw new Exception("There is a problem with a view, please contact the support..");
        }

    }


}
