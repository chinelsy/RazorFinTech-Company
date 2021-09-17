using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinTech
{
      class DataBase
      {
           public static IEnumerable<Users> Users = new List<Users>()
           {
               new Users{Password = "chikki", Email = "chikki@gmail.com"},
               new Users{Password = "alex",   Email = "alex@gmail.com"},
               new Users{Password = "uriel",  Email = "uriel@gmail.com"},
               new Users{Password = "dara",   Email = "dara@gmail.com"},
               new Users{Password = "sammy",  Email = "sammy@gmail.com"},
             
           };


            public static IEnumerable<UserCredentials> UserCredentials = new List<UserCredentials>()
            {
               new UserCredentials { FullName = "Chi Agu", UserName = "Chikki", Address = "10 College road", Email = "chikki@gmail.com", AccountNumber = 0123456789 },
               new UserCredentials { FullName = "King Alex", UserName = "KingAlex", Address = "10 Agbani road", Email = "alex@gmail.com", AccountNumber = 0123456781 },
               new UserCredentials { FullName = "Obi Uriel", UserName = "AngelUriel", Address = "10 Obiage road", Email = "uriel@gmail.com", AccountNumber = 0123456782 },
               new UserCredentials { FullName = "Oluwa Dara", UserName = "Dara-D", Address = "10 Church road", Email = "dara@gmail.com", AccountNumber = 0123456783 },
               new UserCredentials { FullName = "Obaskie Sammy", UserName = "SammySam", Address = "10 Natachi road", Email = "sammy@gmail.com", AccountNumber = 0123456784 },
             
            }; 
            
           
      }   
}
