using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Podaj a");
        a = (int) inputValue();

        Console.WriteLine("Podaj b");
        b = (int) inputValue();
        int z;
        double y;

        Console.WriteLine("Wybierz dzialanie: 1.dodawanie 2.odejmowanie 3.mnozenie 4.dzielenie");
        z = (int) inputValue();
        if (z == 1)
        {
            y = a + b;
            Console.WriteLine(y);
        }
        else
        {
            if (z == 2)
            {
                y = a - b;
                Console.WriteLine(y);
            }
            else
            {
                if (z == 3)
                {
                    y = a * b;
                    Console.WriteLine(y);
                }
                else
                {
                    if (z == 4)
                    {
                        if (z == 4 && b == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez zero!");
                            Console.WriteLine("Wynik: " + a + "/0");
                        }
                        else
                        {
                            y = (double) a / b;
                            Console.WriteLine(y);
                        }
                    }
                    else
                    {
                        string blad;
                        
                        blad = "Wybierz dzialanie od 1 do 4";
                        Console.WriteLine(blad);
                    }
                }
            }
        }
    }
    
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
