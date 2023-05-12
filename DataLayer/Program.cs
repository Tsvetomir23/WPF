using System;
using DataLayer.Database;
using DataLayer.Model;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();   
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "Misho",
                    Password = "12315",
                    Expires = DateTime.Now.AddDays(10),
                    Role = UserRolesEnums.STUDENT
                });

                context.SaveChanges();
                var users = context.Users.ToList(); 
                Console.Write(users.Count);
                Console.ReadKey();
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}