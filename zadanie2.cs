using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double pole, r;
        
        Console.WriteLine("Podaj pole");
        pole = inputValue();
        
        r = Math.Sqrt(pole / 3.14);
        pole = 3.14 * (r * r);
        double obwod;
        
        obwod = 2 * 3.14 * r;
        Console.WriteLine(obwod);
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
