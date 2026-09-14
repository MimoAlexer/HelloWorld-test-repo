public static class FehlerFinden
{
    public static void Main()
    {
        Console.Write("Wie alt bist du? ");
        string alterText = Console.ReadLine() ?? "";

        int alter = Convert.ToInt32(alterText);
        int nächstesJahr = alter + 1;

        Console.WriteLine("Naechstes Jahr bist du " + nächstesJahr);
    }
}
