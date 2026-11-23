using Task2;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        
        calc.PrintWelcome();
        
        int sum = calc.Add(15, 62);
        Console.WriteLine("Addition: " + sum);
        
        int result1 = calc.Multiply(9, 8);
        Console.WriteLine("Multiplication: " + result1);
        
        int result2 = calc.Multiply(8);
        Console.WriteLine("Multiplication with default value: " + result2);
    }
}