using System.Text;

namespace DecimalToBinary;

public class App
{
    public string Run(string? inputNumber)
    {
        if (string.IsNullOrWhiteSpace(inputNumber))
        {
            return string.Empty;
        }
        
        var isNumber = int.TryParse(inputNumber, out int number);
        if (!isNumber)
        {
            throw new FormatException("Invalid Decimal number");
        }

        var isPositive = int.IsPositive(number);
        if (!isPositive)
        {
            throw new FormatException("Invalid Decimal number");
        }

        StringBuilder result = new StringBuilder();
        Stack<int> stack = new Stack<int>();
        while (number > 0)
        {
            stack.Push(number % 2);
            number /= 2;
        }

        foreach (int item in stack)
        {
            result.Append(item);
        }
        
        return result.ToString();
    }
}