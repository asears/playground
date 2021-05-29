using System;

namespace playground
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine("args: {0}", arg);
            }
            const int i = 1;
            while (i == 1)
            {
                Console.WriteLine("Hello 6.0 World!");
                Console.ReadKey();
            }
        }
    }
}
