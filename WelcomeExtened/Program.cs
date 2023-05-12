using UserLogin;
using System;
using UserLogin.Model;
using UserLogin.ViewModel;
using UserLogin.View;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtened.Data;
using WelcomeExtened.Helpers;

class Program
{
   static void Main(string[] args)
    {
        try
        {
            //------ Example 2
            //var user = new User
            //{
            //    Name = "John Smith",
            //    Password = "pass1q2w3e",
            //    Role = UserRolesEnums.STUDENT
            //};

            //var viewModel = new UserViewModel(user);

            //var view = new UserView(viewModel);

            //view.Display();

            //view.DisplayError();

            // ------ Example 3

            UserData userData = new UserData();

            User studentUser = new User()
            {
                Name = "student",
                Password = "1234",
                Role = UserRolesEnums.STUDENT
            };

            userData.AddUser(studentUser);

        }
        catch (Exception ex)
        {
            var log = new ActionOnError(Log);
            log(ex.Message);
        } finally {
            Console.WriteLine("Finally block ... executed in any case");
                }
    }
}