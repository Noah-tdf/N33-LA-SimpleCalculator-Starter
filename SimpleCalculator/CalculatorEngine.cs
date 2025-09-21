using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "+":
                case "plus":
                
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "minus":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                case "times":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "divide":
                    if (argSecondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return 0;
                    }
                    result = argFirstNumber / argSecondNumber;
                    break;

                default:
                    Console.WriteLine("Invalid operation. Valid operations are: +, -, *, /");
                    break;
            }

            return result;
        }
    }
}
