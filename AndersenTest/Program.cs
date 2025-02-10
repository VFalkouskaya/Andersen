namespace TaskApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 7)
        {
            Console.WriteLine("Hello");
        }

        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        if (name.ToLower() == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        int[] array = { 1, 3, 6, 7, 9, 12, 15 };
        foreach (int num in array)
        {
            if (num % 3 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}