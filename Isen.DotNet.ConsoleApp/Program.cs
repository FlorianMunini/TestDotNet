using System;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.InMemory;
using Isen.DotNet.Library.Repositories.Interfaces;

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

            ICityRepository cityRepository = new InMemoryCityRepository ();
            IPersonRepository personRepository = new InMemoryPersonRepository (cityRepository);
           /*  // Toutes les villes
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
            Console.WriteLine("----------------------");
            // Toutes les Person
            foreach (var p in personRepository.GetAll()) Console.WriteLine(p);
            Console.WriteLine("----------------------");
            // Person nés après 1995
            var personBornAfter =
                personRepository.Find(p =>
                p.BirthDate.HasValue &&
                p.BirthDate.Value.Year >= 1996);
            foreach (var p in personBornAfter) Console.WriteLine(p);
            Console.WriteLine("----------------------");

            // Person ayant plus de 21 ans
            var personOlderThan = personRepository.Find (p =>
                p.Age.HasValue &&
                p.Age.Value>=22);
            foreach (var p in personOlderThan) Console.WriteLine(p);
            Console.WriteLine("----------------------");

            // City ayant un e
            var citiesWithE =
                cityRepository.Find (c=>
                    c.Name.IndexOf("e",StringComparison.CurrentCultureIgnoreCase)>=0);
            foreach (var p in citiesWithE) Console.WriteLine(p);
            Console.WriteLine("----------------------");
            
            // Delete de Epinal
            var epinal = cityRepository.Single("Epinal");
            cityRepository.Delete(epinal);
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c); 
            Console.WriteLine("----------------------");

            // Delete une personne 
            personRepository.Delete (1);
            foreach  (var p in personRepository.GetAll()) Console.WriteLine(p);
            Console.WriteLine("----------------------"); */

            // Ajouter une ville 
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
            Console.WriteLine("----------------------");
            var cannes = new City {Name="Cannes"};
            cityRepository.Update(cannes);
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
            Console.WriteLine("----------------------");
            var epinal = cityRepository.Single("Epinal");

            if (epinal != null) {

                epinal.Name+= " sur mer";
                cityRepository.Update(epinal);
                foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
                Console.WriteLine("----------------------");

             }

            // Ajout et mise a jour dans les updates
            var lyon = new City {Name = "Lyon"};
             if (epinal != null) {
                 epinal.Name= "Epinal";
                cityRepository.UpdateRange(lyon,epinal);
                foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
                Console.WriteLine("----------------------");

             }

            var jonDoe = new Person {

                FirstName="Jon",
                LastName="Doe",
                BirthDate=new DateTime (1975,8,11),
                City = cityRepository.Single("Lyon")
            };
            var person2= personRepository.Single(4);
            person2.BirthDate=person2.BirthDate.Value.AddYears(-100);
            personRepository.UpdateRange(jonDoe,person2);
            foreach (var p in personRepository.GetAll()) Console.WriteLine(p);
            Console.WriteLine("----------------------");

        }
    }
}
