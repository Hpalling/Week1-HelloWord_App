using System;

namespace HW
{
    class Program
    {
        public static string Username { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("What is ypur name?");
            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Hello, " + UserName);

            Console.Read();
        }
    }
}

