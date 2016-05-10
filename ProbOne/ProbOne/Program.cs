using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a solution to problem 1 posed on https://projecteuler.net/problem=1
/// Multiples of 3 and 5
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9.
/// The sum of these multiples is 23.
/// Find the sum of all the multiples of 3 or 5 below 1000.
/// </summary>
namespace ProbOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = FindMultipleSum(3, 5, 1000);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        private static string FindMultipleSum(int first, int second, int multiple)
        {
            int current = 1;
            string response = string.Empty;
            int sum = 0;

            while (current < multiple)
            {
                if (current % 3 == 0 || current % 5 == 0)
                {
                    response += current + ","; // add numbers to list
                    sum += current; // add number to sum
                }
                current++; // advance iteration
            }

            response = response.Substring(0, response.Length - 1);
            response += "\nTotal: " + sum;
            return response;
        }
    }
}
