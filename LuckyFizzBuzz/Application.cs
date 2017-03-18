using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyFizzBuzz
{
    public class Application
    {
        public string Run(string input)
        {
            var numbers = input.Split(' ');
            var output = new List<string>();

            foreach (var rawNumber in numbers)
            {
                var number = int.Parse(rawNumber);
                var isFizz = number % 3 == 0;
                var isBuzz = number % 5 == 0;

                if (rawNumber.Contains("3"))
                {
                    output.Add("lucky");
                }
                else
                {
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
            }

            return string.Join(" ", output.ToArray());
        }
    }
}
