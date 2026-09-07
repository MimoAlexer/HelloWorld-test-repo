public static class StringOperationen
{
    public static void Main()
    {
        Console.Write("Gib deinen Namen ein: ");
        string benutzerName = Console.ReadLine() ?? "";

        Console.WriteLine("Grossbuchstaben: " + benutzerName.ToUpper());
        Console.WriteLine("Kleinbuchstaben: " + benutzerName.ToLower());

        Console.Write("Gib das erste Wort ein: ");
        string wort1 = Console.ReadLine() ?? "";

        Console.Write("Gib das zweite Wort ein: ");
        string wort2 = Console.ReadLine() ?? "";

        string neuesWort = wort1 + wort2;
        Console.WriteLine("Neues Wort: " + neuesWort);
    }
}
