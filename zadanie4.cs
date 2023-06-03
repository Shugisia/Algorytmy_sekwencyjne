using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        Console.WriteLine("Wprowadz a");
        a = (int) inputValue();

        Console.WriteLine("Wprowadz b");
        b = (int) inputValue();

        Console.WriteLine("Wprowadz c");
        c = (int) inputValue();

        Console.WriteLine("Wprowadz d");
        d = (int) inputValue();
        
        string error;
        double x, y;
        
        error = "brak rozwiazania";
        if (b == 0 || d == 0)
        {
            Console.WriteLine(error);
        }
        else
        {
            x = a + c;
            y = b + d;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
