using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static string Add(string number)
        {
            //check if 
            if (string.IsNullOrEmpty(number))
            {
                return "0";
            }

            var numbers = number.Split(',').ToList();

            List<double> nums = new List<double>();

            foreach (var item in numbers)
            {
                bool isNumber = double.TryParse(item, out double result);

                // check if the item is a number
                if (isNumber)
                {
                    nums.Add(result);
                }
                // check if last item is empty 
                else if (numbers.IndexOf(item) == numbers.Count - 1 && string.IsNullOrEmpty(item))
                {
                    throw new InvalidOperationException("Missing number in last position");
                }
                else
                {
                    throw new Exception("invalid inputs, please input numbers without any special characters, white spaces or letters");
                }
            }

            var negativeNumbers = string.Join(',', nums.Where(n => n < 0));

            //check for negative numbers and print the negative numbers
            if (negativeNumbers.Length > 0)
            {
                throw new ArgumentException($"Negative not allowed: {negativeNumbers}", negativeNumbers);
            }

            return nums.Sum().ToString();
        }
    }
}
