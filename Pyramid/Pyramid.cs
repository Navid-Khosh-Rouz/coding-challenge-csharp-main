using System;
using System.Linq;
using System.Text;

/*
 
    *
   ***
  *****
 *******
*********

Consider the input as 100:

Before optimization: 
Time taken: 2,9879ms
--------------------
After optimization: 
Time taken: 0,1352ms

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            // uncomment to see the taken time 
            // var watch = System.Diagnostics.Stopwatch.StartNew();

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

                // Due to the c# documentation, StringBuilder is more efficient to merge strings
                var row = new StringBuilder((i + 1) + ". ");
                var padding = height - i - 1;
                row.Append(new string(' ', padding));
                row.Append(new string('*', width - padding * 2));
                Console.WriteLine(row);
            }

            // uncomment to see the taken time 
            // the code that you want to measure comes here
            /* var elapsedMs = watch.Elapsed.TotalMilliseconds;
            watch.Stop(); 
            Console.WriteLine("Time taken: {0}ms", elapsedMs);*/
        }

        public static void Main(string[] args)
        {
            Pyramid(100);
        }
    }
}