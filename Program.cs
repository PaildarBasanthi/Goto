using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Enter user name");
            username= Console.ReadLine();
            if(username.Length>=6 ) {
                Console.WriteLine("Welcome : \t " + username);

            }
            else
            {
                Console.WriteLine("Invalid username");
            }
            Console.ReadKey();
        }
    }
}
