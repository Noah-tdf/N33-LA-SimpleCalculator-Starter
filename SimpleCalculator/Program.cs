using System;



namespace CalculatorEngineLibrary
{
    class Program        //foes ts work gnagfddfg
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

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
