using System;

namespace Play.World
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine("args: {0}", arg);
            }

            ConsoleKeyInfo key;
            bool intercept = true;

            do
            {
                Console.WriteLine("Hello 6.0 World!");

                key = Console.ReadKey(intercept);

            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
