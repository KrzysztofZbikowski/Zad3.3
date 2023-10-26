class Zad
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj pierwszą liczbę: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj trzecią liczbę: ");
        c = double.Parse(Console.ReadLine());
        if (a < b && a < c)
        {
            Console.WriteLine("Najmniejsza liczba wynosi " + a);
        }
        else if (b < c && b < c)
        {
            Console.WriteLine("Najmniejsza liczba wynosi " + b);
        }
        else
        {
            Console.WriteLine("Najmniejsza liczba wynosi " + c);
        }
        Console.ReadKey();
    }
}