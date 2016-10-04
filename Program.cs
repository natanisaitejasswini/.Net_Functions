using System;

namespace ConsoleApplication
{
    public class Program
    {
        //New Function Declaration --- If you want to pass parameter specify type of value also to pass
        //we can also default value to pass if function invoking doesnot pass any parameter it uses this value.
        public static void SayHello(string name = "buddy") 
        {
            Console.WriteLine("Hello, {0}, how are you doing today?", name);
        }
        public static string SayReturn(string name1 = "buddy") // No void but method must have type of return 
        {
            return "Hello" + name1;
        }
        public static void Main(string[] args)
        {
            // Calling Above DEclared function
            SayHello();
            SayHello("Teju");
            // Example of Function Return
            string greeting;
            greeting = SayReturn();
            Console.WriteLine(greeting);
        }
    }
}

