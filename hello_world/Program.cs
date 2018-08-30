using System;

namespace hello_world
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi, input, your name, please");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
