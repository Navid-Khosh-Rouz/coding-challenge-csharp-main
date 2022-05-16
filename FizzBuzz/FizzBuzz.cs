using System;
using System.Collections.Generic;

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
        private FizzBuzzRule[] rules {get; set;}

        public FizzBuzzEngine()
        {
            this.rules = new FizzBuzzRule[]{};
        }

        public FizzBuzzEngine(FizzBuzzRule[] r)
        {
            this.rules = r;
        }

        public void Run(int limit = 100)
        {
            for (int i = 1; i <= limit; i++)
            {
                string output = "";
                foreach (FizzBuzzRule rule in this.rules)
                {
                    if (rule.op(i))
                    {
                        output += rule.output;
                    }
                }


                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }
                
                Console.WriteLine("{0}: {1}", i, output);
            }
        }
    }

    public class FizzBuzzRule
    {
        public Func<int, bool> op {get; set;}
        public string output {get; set;}
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizz = new FizzBuzzRule();
            fizz.op = x => x % 3 == 0;
            fizz.output = "Fizz";

            var buzz = new FizzBuzzRule();
            buzz.op = x => x % 5 == 0;
            buzz.output = "Buzz";

            var bar = new FizzBuzzRule();
            bar.op = x => x % 7 == 0;
            bar.output = "Bar";

            var foo = new FizzBuzzRule();
            foo.op = x => (x * 10) > 100;
            foo.output = "Foo";

            var rulez = new FizzBuzzRule[]{ fizz, buzz, bar, foo };
            FizzBuzzEngine engine = new FizzBuzzEngine(rulez);
            engine.Run();
        }
    }
}
