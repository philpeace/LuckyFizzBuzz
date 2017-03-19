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
            var counter = new Dictionary<string, int>
            {
                { "fizz", 0 },
                { "buzz", 0 },
                { "fizzbuzz", 0 },
                { "lucky", 0 },
                { "integer", 0 }
            };
            
            foreach (var rawNumber in numbers)
            {
                if (rawNumber.Contains("3"))
                {
                    output.Add("lucky");
                    counter["lucky"]++;
                }
                else
                {
                    var number = int.Parse(rawNumber);
                    var isFizz = number % 3 == 0;
                    var isBuzz = number % 5 == 0;

                    if (isFizz && isBuzz)
                    {
                        output.Add("fizzbuzz");
                        counter["fizzbuzz"]++;
                    }
                    else if (isFizz)
                    {
                        output.Add("fizz");
                        counter["fizz"]++;
                    }
                    else if (isBuzz)
                    {
                        output.Add("buzz");
                        counter["buzz"]++;
                    }
                    else
                    {
                        output.Add(number.ToString());
                        counter["integer"]++;
                    }
                }
            }

            var report = counter.Aggregate("", (current, item) => current + $"{item.Key}: {item.Value}\n");

            return string.Join(" ", output.ToArray()) + "\n" + report.Trim();
        }
    }
}
