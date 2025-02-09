using CICD_Core;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int a = GetValidNumber();
        Console.WriteLine("Enter second number:");
        int b = GetValidNumber();

        double sum = Calculator.Divide(a, b);
        Console.WriteLine("Sum: " + sum);
    }

    static int GetValidNumber()
    {
        int number;
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                return number;
            }
            Console.WriteLine("Invalid Input! Please enter an integer:");
        }
    }

}