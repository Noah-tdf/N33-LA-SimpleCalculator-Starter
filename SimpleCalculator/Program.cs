using System;



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

                Console.WriteLine($"Result: {result:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
