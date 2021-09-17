using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinTech
{
    class Application
    {
        public static async Task UserDataBaseAsync() 
        {
            Console.WriteLine("waiting for verification");
            Console.WriteLine("Enter your Email");
            var email = RePrompt(Console.ReadLine());

            Console.WriteLine("Enter your Password");
            var password = RePrompt(Console.ReadLine());

            var getValidUserTask = CheckingDB.LogInUserAsync(password, email);
            var getCredentialTask = CheckingDB.GetUserCredentialsAsync(email);
            Console.WriteLine("Waiting for the two task asynchronously..");

            var validatingUser = await getValidUserTask;
            var UserCredentail = await getCredentialTask;
            if (validatingUser)
            {
                Console.WriteLine();
                Console.WriteLine("Below are my credential's Info:");
                Console.WriteLine($"{UserCredentail.FullName}'s profile");
                Console.WriteLine($" FullName: {UserCredentail.FullName}");
                Console.WriteLine($" UserName: {UserCredentail.UserName}");
                Console.WriteLine($" Address: {UserCredentail.Address}");
                Console.WriteLine($" Emial: {UserCredentail.Email}");
                Console.WriteLine($" AccountNumber: {UserCredentail.AccountNumber}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid User"); 
                Console.ResetColor();
            }


        }
        public static string RePrompt(string input)
        { 
            while (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Field cannot be blank");
                input = Console.ReadLine();
            }
            return input;
            
        }
        
        

    }
}
