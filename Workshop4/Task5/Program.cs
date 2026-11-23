using Task5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the day (Example: Sunday): ");
        string day = Console.ReadLine();

        DayType dayType;
        
        if (day.ToLower() == "friday" || day.ToLower() == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine("It is: " + dayType);
        
        Book book1 = new Book("C# Basics", "Nishan Gurung", 580.0);
        Book book2 = book1 with { title = "Advanced C#", price = 1050.0 };
        
        Console.WriteLine("Book 1: " + book1);
        
        var (title, author, price) = book2;
        Console.WriteLine("Book 2 Title: " + title);
        Console.WriteLine("Book 2 Author: " + author);
        Console.WriteLine("Book 2 Price: " + price);
    }
}