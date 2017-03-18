using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyFizzBuzz
{
    public class Application
    {
        public string Run(string input)
        {
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            var output = new List<string>();

            foreach (var number in numbers)
            {
                var isFizz = number % 3 == 0;
                var isBuzz = number % 5 == 0;

                if (isFizz && isBuzz)
                {
                    output.Add("fizzbuzz");
                }
                else if (isFizz)
                {
                    output.Add("fizz");
                }
                else if (isBuzz)
                {
                    output.Add("buzz");
                }
                else
                {
                    output.Add(number.ToString());                   
                }
            }

            return string.Join(" ", output.ToArray());
        }
    }
}
