using Task_2;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("PI = " + Circle.PI);
        
        //PI in Circle class is declared as const therefore when i try to modify it then it shows error
        Circle.PI = 3.14589;
    }
}