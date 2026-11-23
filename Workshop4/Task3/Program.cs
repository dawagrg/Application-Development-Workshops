using Task3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();
        int number = 20;
        demo.Increase(ref number);

        Console.WriteLine("Increased Number: " + number);
        string fullname;

        demo.GetFullName(out fullname);
        Console.WriteLine("Full Name: " + fullname);

        int total = demo.SumAll(10, 20, 30, 40, 50);
        Console.WriteLine("Sum of All Numbers: " + total);
    }
}