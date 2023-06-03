using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Podaj a");
        a = (int) inputValue();

        Console.WriteLine("Podaj b");
        b = (int) inputValue();

        Console.WriteLine("Podaj c");
        c = (int) inputValue();
        string blad;
        
        blad = "Z podanych wartości nie mozna zbudowac trojkata rownobocznego";
        string poprawne;
        
        poprawne = "Mozna zbudowac trojkat rownobczny";
        if (a == b && a == c && b == c)
        {
            Console.WriteLine(poprawne);
        }
        else
        {
            Console.WriteLine(blad);
        }
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
