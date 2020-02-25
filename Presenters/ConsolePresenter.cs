using System;

namespace ConsoleDI.Presenters
{
    public class ConsolePresenter : IPresenter
    {
        public Tuple<int, int> AskOperands()
        {
            Console.WriteLine("Please input two operands for the operation:");
            Console.WriteLine("Operand 1:");
            var operand1 = Console.ReadLine();
            Console.WriteLine("Operand 2:");
            var operand2 = Console.ReadLine();
            return new Tuple<int, int>(Convert.ToInt16(operand1), Convert.ToInt16(operand2));
        }

        public String AskOperation()
        {
            Console.WriteLine("Choose the math operation: " + Environment.NewLine +
                "1 - Sum" + Environment.NewLine +
                "2 - Subtract" + Environment.NewLine +
                "3 - Multiply" + Environment.NewLine +
                "4 - Division");
            var operation = Console.ReadLine();
            return operation;
        }

        public void ShowResult(int result)
        {
            Console.WriteLine($"The result of your operation is {result}");
        }
    }
}