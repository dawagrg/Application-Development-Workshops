public class Program
{
    public static void Main()
    {
        byte byteValue =  255;
        short shortValue = 256;
        int intValue = 42;
        long longValue = 258;
        float floatValue = 259;
        double doubleValue = 260.10;
        decimal decimalValue = 261.20m;
        char charValue = 'h';
        bool boolValue = true;
        string stringValue = "3.14";

        string convertedString = intValue.ToString();
        double convetedDouble = Convert.ToDouble(stringValue);
        
        Console.WriteLine("Byte: " + byteValue);
        Console.WriteLine("Short: " + shortValue);
        Console.WriteLine("Int: " + intValue);
        Console.WriteLine("Long: " + longValue);
        Console.WriteLine("Float: " + floatValue);
        Console.WriteLine("Double: " + doubleValue);
        Console.WriteLine("Decimal: " + decimalValue);
        Console.WriteLine("Char: " + charValue);
        Console.WriteLine("Bool: " + boolValue);
        Console.WriteLine("Converted Int to String Value: " + convertedString);
        Console.WriteLine("Converted Double to String Value: " + convetedDouble);
        
    }
}