using System;
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
        /// <param name="numbers">String of numbers to add, separated by newline</param>
        /// <returns>Integer of the additive result of the input numbers</returns>
        public static int Add(string numbers)
        {
            // Parse and Validate input
            var parsedInput = (numbers ?? string.Empty)
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i));

            // Calculate results
            var result = 0;
            foreach (var num in parsedInput)
                result += num;

            return result;
        }
    }
}
