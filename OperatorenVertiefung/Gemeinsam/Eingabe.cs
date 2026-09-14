using System.Globalization;

namespace OperatorenVertiefung;

internal static class Eingabe
{
    public static void Start(Action programm)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-CH");
        try
        {
            programm();
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("\nEingabe beendet. Programm wird geschlossen.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Die Zahlen sind für diese Berechnung zu gross.");
            Environment.ExitCode = 1;
        }
    }

    public static string Text(string aufforderung)
    {
        Console.Write(aufforderung);
        return Console.ReadLine() ?? throw new EndOfStreamException();
    }

    public static decimal Dezimalzahl(string aufforderung)
    {
        while (true)
        {
            string text = Text(aufforderung).Replace(',', '.');
            if (decimal.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal zahl))
                return zahl;
            Console.WriteLine("Bitte eine gültige Zahl ohne Tausendertrennzeichen eingeben.");
        }
    }

    public static double ReelleZahl(string aufforderung, bool nullErlaubt = false)
    {
        while (true)
        {
            string text = Text(aufforderung).Replace(',', '.');
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double zahl)
                && double.IsFinite(zahl) && (zahl > 0 || (nullErlaubt && zahl == 0)))
                return zahl;
            Console.WriteLine(nullErlaubt
                ? "Bitte eine endliche Zahl grösser oder gleich 0 eingeben."
                : "Bitte eine endliche Zahl grösser als 0 eingeben.");
        }
    }

    public static int Ganzzahl(string aufforderung, int maximum = int.MaxValue)
    {
        while (true)
        {
            if (int.TryParse(Text(aufforderung), out int zahl) && zahl >= 0 && zahl <= maximum)
                return zahl;
            Console.WriteLine($"Bitte eine ganze Zahl zwischen 0 und {maximum} eingeben.");
        }
    }

    public static void Ergebnis(string bezeichnung, double wert, string einheit, int stellen = 2)
    {
        if (!double.IsFinite(wert))
            throw new OverflowException();
        Console.WriteLine($"{bezeichnung}: {Math.Round(wert, stellen, MidpointRounding.AwayFromZero).ToString($"F{stellen}")} {einheit}");
    }
}
