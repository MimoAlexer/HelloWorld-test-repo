public static class EinfacheEingabeAusgabe
{
    public static void Main()
    {
        Console.Write("Wie heisst du? ");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Hallo " + name);

        Console.Write("Gib die erste Ganzzahl ein: ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gib die zweite Ganzzahl ein: ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        int summe = zahl1 + zahl2;
        Console.WriteLine("Die Summe ist: " + summe);
    }
}
