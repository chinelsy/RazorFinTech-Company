using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RazorFinTech
{
    class CheckingDB 
    {
        public static async Task <bool> LogInUserAsync(string password, string email)
        {
            
            await Task.Delay(6000);
            var user = DataBase.Users.FirstOrDefault<Users>(s => s.Password == password && s.Email == email);

            if (user == null)
            {
                return false;
            } 
            
            return true;
        }
        public static async Task<UserCredentials> GetUserCredentialsAsync(string email)
        {
            var user = DataBase.UserCredentials.FirstOrDefault<UserCredentials>(e => e.Email == email); 
            Console.WriteLine("Verifying users email");
            await Task.Delay(3000);
            if (user == null) 
            {
                return user;
            }
            return user;


        }
    }
}
