using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignement2
{
    internal class numberstowords
    {
        static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public static string ConvertToWords(int number)
        {
            if (number >= 1000)
            {
                return $"{units[number / 1000]} Thousand {ConvertToWords(number % 1000)}";
            }
            else if (number >= 100)
            {
                return $"{units[number / 100]} Hundreds {ConvertToWords(number % 100)}";
            }
            else if (number >= 20)
            {
                return $"{tens[number / 10]} {units[number % 10]}";

            }
            else if (number >= 11)
            {
                return $"{teens[number - 10]}";
            }
            else
            {
                return $"{units[number]}";

            }

        }

    }
}
    

