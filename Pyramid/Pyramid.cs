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
            var width = (height * 2) - 1;
            foreach (var i in Enumerable.Range(0, height))
            {
                var row = "";
                var padding = height - i - 1;
                
                foreach (var _ in Enumerable.Range(0, padding))
                {
                    row += " ";
                }

                foreach (var _ in Enumerable.Range(0, width - padding * 2))
                {
                    row += "*";
                }

                foreach (var _ in Enumerable.Range(0, padding))
                {
                    row += " ";
                }

                Console.WriteLine(row);
            }
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}