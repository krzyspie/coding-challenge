namespace HexToDecimal;

public class App
{
    public double Run(string? inputHexNumber)
    {
        if (string.IsNullOrWhiteSpace(inputHexNumber))
        {
            throw new ArgumentNullException(nameof(inputHexNumber));
        }
        
        double result = 0;
        var powerFactor = inputHexNumber.Length - 1;
        for (int i = 0; i < inputHexNumber.Length; i++)
        {
            var hexNumberChar = inputHexNumber[i];
            var number = GetNumber(hexNumberChar);
            var factor = Math.Pow(16, powerFactor - i);
            result += number * factor;
        }
        
        return result;
    }
    
    private double GetNumber(char hexNumberChar)
    {
        if (!char.IsDigit(hexNumberChar))
        {
            return hexNumberChar switch
            {
                'a' => 10,
                'A' => 10,
                'b' => 11,
                'B' => 11,
                'c' => 12,
                'C' => 12,
                'd' => 13,
                'D' => 13,
                'e' => 14,
                'E' => 14,
                'f' => 15,
                'F' => 15,
                _ => throw new FormatException($"Invalid hex number character: {hexNumberChar}")
            };
        }

        var number = double.Parse(hexNumberChar.ToString());

        if (number is >= 0 and <= 9)
        {
            return number;
        }
    
        throw new FormatException($"Invalid hex number character: {hexNumberChar}");
    }
}