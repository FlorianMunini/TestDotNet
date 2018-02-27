using System;

namespace Isen.DotNet.Library
{
    public class Hello
    {
        private static string _world = "Hello World";
        public static string World { get; set; }
            ="Hello world";

            // get { return _world; }
            // set { _world = value; }
        //}
        // Renvoie des salutations
        public static string Greet (string name) {
            var time = DateTime.Now.ToString("HH:mm");
            // String interpollation avec $
            var message = $"Hello {name}, it is {time}";
          
            return message;
        }

        public static string GreetUpper (string name) 
            => Greet (name.ToUpper());
          
        
    }
}
