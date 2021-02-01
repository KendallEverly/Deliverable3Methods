/*Author: Kendall Everly
  Date: 01/31/2021
  Comments: This C# console application demonstrates the use of methods after getting input from a user.
 */
using System;

namespace Deliverable3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            //read user input
            string input = Console.ReadLine();
            //show message
            Console.WriteLine("Hello " + input + "!");
            Console.ReadKey(true);
        }
        //end of main
    }
    //end of class
}
//end of method
