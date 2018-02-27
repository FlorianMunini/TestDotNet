using System;
using Isen.DotNet.Library;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             string world = Hello.Greet("Kall");
            Console.WriteLine(world);

            string greet = Hello.World;
            Console.WriteLine(greet);

            var greetUpper = Hello.GreetUpper("Kall");
            Console.WriteLine(greetUpper);
        }
    }
}
