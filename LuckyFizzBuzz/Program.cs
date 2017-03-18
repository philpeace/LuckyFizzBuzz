using System;

namespace LuckyFizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                return;
            }

            var app = new Application();

            var output = app.Run(args[0]);

            Console.WriteLine(output);
        }
    }
}
