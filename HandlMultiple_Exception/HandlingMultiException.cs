using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Multiple__Exceptions
{
    public class HandlingMultiException
    {
        public string HandleMultipleExceptions(string input, int index)
        {
            int[] numbers = { 1, 2, 3, };

            try
            {

                int paresnumber = int.Parse(input);  // Comverterar string to int

                return numbers[index].ToString();
            }
            catch (FormatException)
            {
                return "Invalid format.";
            }
            catch (IndexOutOfRangeException)
            {
                return "Index out of range.";
            }
        }
    }
}
