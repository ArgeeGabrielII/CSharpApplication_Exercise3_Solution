using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a C# Application that accepts two number input and print the result of adding two numbers.
            //Let's Begin! :)

            int value1, value2, result; //First let's declare the variables that we're going to use.

            Console.Write("Please input the first number: "); //We're going to ask the user to input the first number.
            value1 = int.Parse(Console.ReadLine()); //We're going to get the inputted number, then convert it from string to an Int (DataType).
            Console.Write("Please input the second number: ");
            value2 = int.Parse(Console.ReadLine()); //We're going to get the second inputted number, then convert it from string to an Int (DataType).

            result = (value1 + value2); //Now, we're going to add the two inputted values and store the result into our "result" variable.
            Console.WriteLine("The result of adding two numbers is: " + result);

            Console.ReadKey(); //This waits for a keypress, coming from the user, before the application exits.

            //Now, let's run the application, by pressing F5 or clicking the Start Button above. :)
            //We forgot to display the result. Hahaha! :)
        }
    }
}
