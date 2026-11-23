using Task1;

public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.id = 1;
        s1.name = "Dhawa";
        s1.age = 22;

        Console.WriteLine("Student ID: " + s1.id);
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);

        Student s2 = new Student();
        s2.id = 2;
        s2.name = "Sumit";
        s2.age = 21;

        Console.WriteLine("Student ID: " + s2.id);
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        
        Console.WriteLine("Total Students: " + Student.totalStudents);
    }
}
