using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h, bmi;
        
        Console.WriteLine("Wprowadz wage w kg");
        w = inputValue();
        Console.WriteLine("Wprowadz wzrost w m");
        h = inputValue();
        bmi = w / (h * h);
        Console.WriteLine(bmi);
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
