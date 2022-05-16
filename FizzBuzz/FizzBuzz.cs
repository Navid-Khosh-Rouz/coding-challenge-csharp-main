using System;

/**
 *
 * Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
 * number or the corresponding text if one of the following rules apply.
 * Rules:
 *  - dividable by 3 without a remainder -> Fizz
 *  - dividable by 5 without a remainder -> Buzz
 *  - dividable by 3 and 5 without a remainder -> FizzBuzz
 *
 * ACCEPTANCE CRITERIA:
 * Please refactor this code so that it can be easily extended in the future with other rules, such as
 * "if it is dividable by 7 without a remainder output Bar"
 * "if multiplied by 10 is larger than 100 output Foo"
 *
 */

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        public void Run(int limit = 100)
        {
            for (int i = 1; i <= limit; i++)
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }
                
                Console.WriteLine("{0}: {1}", i, output);
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();
            engine.Run();
        }
    }
}
