using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, odlsrd;
        
        Console.WriteLine("Podaj x");
        x = inputValue();

        Console.WriteLine("Podaj y");
        y = inputValue();

        Console.WriteLine("Podaj r");
        r = inputValue();
        
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Wpisane wspolrzedne znajduja sie w obrebie kola");
        }
        else
        {
            Console.WriteLine("Wpisane wspolrzedne NIE znajduja sie w obrebie kola");
        }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
