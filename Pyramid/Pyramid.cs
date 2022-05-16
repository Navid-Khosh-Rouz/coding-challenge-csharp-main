using System;

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
            Console.WriteLine("A beautiful pyramid");
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}