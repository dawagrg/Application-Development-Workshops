public class Program
{
    public static void Main()
    {
        int[] numbers = {5, 8, 9, 3, 2};
        
        // Array in ascending order
        Console.WriteLine("Numbers in ascending order");
        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        // Array in descending order
        Console.WriteLine("Numbers in descending order");
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        // Finding position of a specific number
        int index = Array.IndexOf(numbers, 5);
        Console.WriteLine("Position of number 5: " +index);
    }
}