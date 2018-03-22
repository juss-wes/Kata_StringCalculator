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
        /// <param name="numbers">String of 0 to 2 numbers to add, separated by comma</param>
        /// <returns>Integer of the additive result of the input numbers</returns>
        public static int Add(string numbers)
        {
            // Parse and Validate input
            var parsedInput = (numbers ?? string.Empty)
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i));

            if (parsedInput.Count() > 2)
                throw new ArgumentException("Only 0, 1, or 2 numbers are accepted, each separated by ','", nameof(numbers));

            // Calculate results
            var result = 0;
            foreach (var num in parsedInput)
                result += num;

            return result;
        }
    }
}
