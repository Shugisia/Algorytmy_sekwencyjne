using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj a");
        a = inputValue();

        Console.WriteLine("Podaj b");
        b = inputValue();
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
