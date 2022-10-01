using System;
using System.Linq;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            /* 
            We need only one loop to produce the desired output
            */
            var width = (height * 2) - 1;
            foreach (var i in Enumerable.Range(0, height))
            {
                // to crate each row:
                /* 
                Creating a string which starts with the padding as spaces
                and then we will add the correct number of * that we need to
                each row. => instead of applying three more loops inside the main
                loop.
                 */
                var row = (i + 1) + ". ";
                var padding = height - i - 1;
                row += new string(' ', padding);
                row += new string('*', width - padding * 2);
                Console.WriteLine(row);
            }
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}