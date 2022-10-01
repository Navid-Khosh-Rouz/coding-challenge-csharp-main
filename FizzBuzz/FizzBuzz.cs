using System;
using System.Collections.Generic;

namespace FizzBuzzSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();
            engine.Run();
        }
    }

    // Equivalent to component in decoration pattern
    class FizzBuzzEngine
    {
        private IFizzBuzzSolver _solver { get; set; }

        public FizzBuzzEngine()
        {
            this._solver =
                new FizzDecorator(
                new BuzzDecorator(
                new BarDecorator(
                new FooDecorator(
                new FizzBuzz()
                ))));
        }

        public void Run(int limit = 100)
        {
            Console.WriteLine("Solving FizzBuzz problem by using Decorator pattern.");
            Console.WriteLine("Feel free to add other rules on runtime.");
            Console.WriteLine("Default limitation is 100.");

            for (int i = 1; i < limit + 1; i++)
            {
                Console.WriteLine(_solver.solve(i));
            }
        }
    }

    // The base interface defines operations
    interface IFizzBuzzSolver
    {
        string solve(int number, string output = "");
    }

    // the default value to solve
    // concrete (component) implementation
    class FizzBuzz : IFizzBuzzSolver
    {
        public string solve(int number, string output = "")
        {
            if (output == "")
            {
                output = number.ToString();
            }

            return number.ToString() + " : " + output;
        }
    }

    // base decorator to solve the problem
    class BaseFizzBuzzDecorator : IFizzBuzzSolver
    {
        private IFizzBuzzSolver _fizzBuzzSolver;

        // injecting as interface, so we can make that this class won't change in future
        public BaseFizzBuzzDecorator(IFizzBuzzSolver fizzBuzzSolver)
        {
            _fizzBuzzSolver = fizzBuzzSolver;
        }

        // having the 'solve' function as virtual => so it can be overridden by other concrete decorators
        public virtual string solve(int number, string output)
        {
            return _fizzBuzzSolver.solve(number, output);
        }
    }

    /* 
    ****************
    concrete decorators
    ****************
    */
    // concrete decorators => check if is dividable by 3 (Fizz)
    class FizzDecorator : BaseFizzBuzzDecorator
    {
        public FizzDecorator(IFizzBuzzSolver fizzBuzzSolver) : base(fizzBuzzSolver) { }

        public override string solve(int number, string output)
        {
            if (number % 3 == 0)
            {
                output += "Fizz";
            }

            return base.solve(number, output);
        }
    }

    // concrete decorators => check if is dividable by 5 (Buzz)
    class BuzzDecorator : BaseFizzBuzzDecorator
    {
        public BuzzDecorator(IFizzBuzzSolver fizzBuzzSolver) : base(fizzBuzzSolver) { }

        public override string solve(int number, string output)
        {
            if (number % 5 == 0)
            {
                output += "Buzz";
            }

            return base.solve(number, output);
        }
    }

    // concrete decorators => check if is dividable by 7 (Bar) 
    class BarDecorator : BaseFizzBuzzDecorator
    {
        public BarDecorator(IFizzBuzzSolver fizzBuzzSolver) : base(fizzBuzzSolver) { }

        public override string solve(int number, string output)
        {
            if (number % 7 == 0)
            {
                output += "Bar";
            }

            return base.solve(number, output);
        }
    }

    // concrete decorators => check multiplied by 10 is larger than 100 (Foo) 
    class FooDecorator : BaseFizzBuzzDecorator
    {
        public FooDecorator(IFizzBuzzSolver fizzBuzzSolver) : base(fizzBuzzSolver) { }

        public override string solve(int number, string output)
        {
            if (number * 10 > 100)
            {
                output += "Foo";
            }

            return base.solve(number, output);
        }
    }

}