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
        /// <param name="numbers">String of numbers to add, separated by delimiters either user defined, ',' or '\n'</param>
        /// <returns>Integer of the additive result of the input numbers</returns>
        public static int Add(string numbers)
        {
            // Parse
            var parsedInput = ParseInput(numbers);

            // Calculate results
            var result = 0;
            var invalidChars = string.Empty;
            foreach (var num in parsedInput)
            {
                if (num < 0)
                    invalidChars += $"{num},";
                else if (num < 1000)
                    result += num;
            }

            if (!string.IsNullOrEmpty(invalidChars))
                throw new ArgumentException($"Negatives not allowed: {invalidChars.TrimEnd(new char[] { ',' })}");

            return result;
        }

        /// <summary>
        /// Separated private method to parse the numerical input and delimiter selection
        /// </summary>
        /// <param name="numbers">Input to parse</param>
        /// <returns>Enumerable of integers from the input string of numbers</returns>
        private static IEnumerable<int> ParseInput(string numbers)
        {
            // Default delimiters
            var delimiters = new List<string>()
            {
                ",",
                "\n"
            };

            // Add custom delimeters, if provided
            if (numbers.StartsWith("//"))
            {
                var tempDelimiters = numbers.Substring(2, numbers.IndexOf("\n") - 2).Split(new char[] { '[' });
                foreach (var delimiter in tempDelimiters)
                    delimiters.Add(delimiter.Replace("]", ""));

                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
            }

            // Parse the numerical input
            return (numbers ?? string.Empty)
                .Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i));
        }
    }
}
