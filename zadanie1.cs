using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj 3 liczby");
        double a, b, c;
        
        a = inputValue();
        b = inputValue();
        c = inputValue();
        double sredniaArytmetyczna;
        
        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine(sredniaArytmetyczna);
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
