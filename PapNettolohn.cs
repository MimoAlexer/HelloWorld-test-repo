public static class PapNettolohn
{
    public static void Main()
    {
        Console.WriteLine("PAP:");
        Console.WriteLine("Start");
        Console.WriteLine("Bruttolohn einlesen");
        Console.WriteLine("Steuersatz in Prozent einlesen");
        Console.WriteLine("Steuerbetrag = Bruttolohn / 100 * Steuersatz");
        Console.WriteLine("Nettolohn = Bruttolohn - Steuerbetrag");
        Console.WriteLine("Nettolohn ausgeben");
        Console.WriteLine("Ende");

        Console.WriteLine();
        Console.Write("Gib den Bruttolohn ein: ");
        double bruttolohn = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib den Steuersatz in Prozent ein: ");
        double steuersatz = Convert.ToDouble(Console.ReadLine());

        double steuerbetrag = bruttolohn / 100 * steuersatz;
        double nettolohn = bruttolohn - steuerbetrag;

        Console.WriteLine("Der Nettolohn ist: " + Math.Round(nettolohn, 2));
    }
}
