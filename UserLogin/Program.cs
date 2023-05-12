using System;
using UserLogin.Model;
using UserLogin.View;
using UserLogin.ViewModel;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Name = "Test";
        user.Role = UserRolesEnums.STUDENT;
        UserViewModel userViewModel = new UserViewModel(user);
        UserView userView = new UserView(userViewModel);
        userView.Display();

        Console.ReadKey();
    
    }
}