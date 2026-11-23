public class Program
{
    public static void Main()
    {
        int marks;
        int total;

        Console.Write("Enter marks: ");
        bool marksOk = int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total: ");
        bool totalOk = int.TryParse(Console.ReadLine(), out total);

        if (marksOk && totalOk)
        {
            double percentage = (double)marks / total * 100;
            Console.WriteLine("Percentage: " + percentage);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter whole numbers only.");
        }
    }
}

