using System;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.InMemory;

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

            /* var me = new Person 
            {
                FirstName = "Florian",
                LastName = "Munini",
                City = new City { Name = "Toulon" },
                BirthDate = new DateTime(1996,9,16)
            };
          
            Console.WriteLine(me); */

            var cityRepo = new InMemoryCityRepository ();
            Console.WriteLine(cityRepo.Single(3));
            Console.WriteLine(cityRepo.Single("Toulon"));
            var allCities = cityRepo.GetAll();
            foreach (var c in allCities) Console.WriteLine(c);


        }
    }
}
