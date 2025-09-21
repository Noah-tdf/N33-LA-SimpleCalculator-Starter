using System;

// Noah and Ryan
namespace CalculatorEngineLibrary
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double result;

           
            if (double.TryParse(argTextInput, out result))
            {
                return result;
            }

            throw new ArgumentException("Invalid input, Enter a valid number.");
        }
    }
}
