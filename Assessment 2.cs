using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        long result = 1;
        Console.Write($"{num}! = ");
        for (int i = num; i >= 1; i--)
        {
            result *= i;
            Console.Write(i);
            if (i > 1) Console.Write(" * ");
        }
        Console.WriteLine($" = {result}");
    }
}
