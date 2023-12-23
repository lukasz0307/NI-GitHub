internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imię");
        string imie = Console.ReadLine();
        Console.WriteLine("Podaj swoje Nazwisko");
        string nazw = Console.ReadLine();
        Console.WriteLine("Podaj swój wiek");
        string wiek = Console.ReadLine();
        Console.WriteLine($"Witaj {imie} {nazw} lat {wiek}");
    }
}