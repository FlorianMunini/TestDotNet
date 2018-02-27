using System;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Models.Implementation;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         /* string world = Hello.Greet("Kall");
            Console.WriteLine(world);

            string greet = Hello.World;
            Console.WriteLine(greet);

            var greetUpper = Hello.GreetUpper("Kall");
            Console.WriteLine(greetUpper); */

            var me = new Person 
            {
                FirstName = "Florian",
                LastName = "Munini",
                City = new City { Name = "Toulon" },
                BirthDate = new DateTime(1996,9,16)
            };
          
            Console.WriteLine(me);


        }
    }
}
