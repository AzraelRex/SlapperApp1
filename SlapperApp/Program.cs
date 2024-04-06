public class Program
{
    public static void Main(string[] args)
    {
        int number = 5; // Change this to the number you want to calculate the factorial of
        long result = Factorial(number);
        Console.WriteLine($"The factorial of {number} is {result}");
        Console.WriteLine("Yo C# Is Amazing\n");
        Console.WriteLine("C# Better Than Java!");
    }

    public static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
