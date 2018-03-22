using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    /// <summary>
    /// Class to handle string calculator functionality
    /// </summary>
    public static class StringCalculator
    {
        /// <summary>
        /// Method to add numbers, as encoded in string input
        /// </summary>
        /// <param name="numbers">String of numbers to add, separated by a given delimiter at the start of the string, such as: (\\[delimiter]/n[numbers])</param>
        /// <returns>Integer of the additive result of the input numbers</returns>
        public static int Add(string numbers)
        {
            // Parse and Validate input
            var delimiters = new List<string>()
            {
                ",",
                "\n"
            };

            // Add the custom delimeter, if provided
            if (numbers.StartsWith("//"))
            {
                delimiters.Add(numbers.Substring(2, numbers.IndexOf("\n") - 2));
                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
            }

            // Parse the numerical input
            var parsedInput = (numbers ?? string.Empty)
                .Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i));

            // Calculate results
            var result = 0;
            foreach (var num in parsedInput)
                result += num;

            return result;
        }
    }
}
