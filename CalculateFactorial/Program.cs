/*
Copyright (C) 2023 Darko Milosevic <daremc86@gmail.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 2.1 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.

*/

// .Net library imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CalculateFactorial namespace
namespace CalculateFactorial
{
// Main class of the console application, called Program
    public class Program
    {
        // We'll create method called CalculateNFactorial, where we'll pass one parameter as an integer value.
        // the Method should be static because will be called from the static function (main)
        static int CalculateNFactorial(int nInputNumber)
        {
            // an integer variable contains factorial
            int nFactorial = 1;
            // For loop to pass each number in the input number (nInputNumber) variable
            for (int I = 1; I <= nInputNumber; I++)
            {
                // Asigning the nFactorial variable and multiplying with the value of I
                nFactorial = nFactorial * I;
            }
            // Returns the nFactorial
            return nFactorial;
                }

        // The main function of the console program, usually do not returns anything, because the data type is (void)
        public static void Main(string[] args)
        {
            // Sending input message to a user
            Console.Write("Please input a positive number to calculate factorial");
            // Declaring one integer variable, and assigning value to the input number from the console
            int nInput = int.Parse(Console.ReadLine());
            // Declaring a variable, and assigning the output value from the calculated factorial
            int nOutput = CalculateNFactorial(nInput);
            // Printing result to the console
            Console.Write("Factorial for number " + nInput + " is " + nOutput);
        }
    }
}
