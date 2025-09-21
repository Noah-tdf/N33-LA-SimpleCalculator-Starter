using System;


// Noah and Ryan
namespace CalculatorEngineLibrary
{
    class Program       
    {
        static void Main(string[] args)
        {
            try

            {
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter the first number:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);


                //display the result in a human readable format
                string displayMessage = string.Format("The value {0} plus the value {1} is equal to {2:F2}", firstNumber, secondNumber, result);
                Console.WriteLine(displayMessage);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
