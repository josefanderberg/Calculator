using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välj räknesätt: \n + \n - \n * \n /");
        string calc = Console.ReadLine()!;
        Console.WriteLine("Skriv ditt första tal");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv ditt andra tal");
        int y = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        if (calc == "+")
        { result = x + y; }
        else if (calc == "-")
        { result = x - y; }
        else if (calc == "*" || calc == "x")
        { result = x * y; }
        else if (calc == "/")
        { result = x / y; }
        else
        {
            Console.WriteLine("Skrev du verkligen +, -, * eller ");
        }
        Console.WriteLine("Summan är " + result);
    }
}