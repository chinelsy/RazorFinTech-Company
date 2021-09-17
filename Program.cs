using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinTech
{
    class Program
    {
         static async Task Main(string[] args)
         {
            await Application.UserDataBaseAsync();
            Console.ReadLine();

         }
    }
}
