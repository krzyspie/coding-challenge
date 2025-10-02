namespace PhoneNumberFormatter;

public class App
{
    public string Run(string? phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("No number entered.");
        }
        
        if (phoneNumber.Length != 11)
        {
            throw new ArgumentException("Invalid number entered.");
        }
        
        var isNumber = ulong.TryParse(phoneNumber, out ulong number);
        if (!isNumber)
        {
            throw new ArgumentException("Is not a number.");
        }

        var formattedPhoneNumber = FormatNumber(number);
        
        Console.WriteLine($"Formatted phone number is: {formattedPhoneNumber}");

        return formattedPhoneNumber;
    }
    private string FormatNumber(ulong number)
    {
        string formattedNumber = "";

        for (int i = 0; i < 11; i++)
        {
            var n1 = number % 10;
            formattedNumber = n1.ToString() + formattedNumber;
            if (i == 3)
            {
                formattedNumber = "-" + formattedNumber;
            }

            if (i == 6)
            {
                formattedNumber = ") " + formattedNumber;
            }

            if (i == 9)
            {
                formattedNumber = " (" + formattedNumber;
            }
        
            if (i == 10)
            {
                formattedNumber = "+" + formattedNumber;
            }
        
            number = number / 10;
        }

        return formattedNumber;
    }
}