public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Welche Uebung willst du starten?");
        Console.WriteLine("1 = Variablen und Datentypen");
        Console.WriteLine("2 = Einfache Ein- und Ausgabe");
        Console.WriteLine("3 = Fehler finden");
        Console.WriteLine("4 = String-Operationen");
        Console.WriteLine("5 = PAP Nettolohn");
        Console.WriteLine("6 = Code lesen");
        Console.WriteLine("7 = Grundrechenarten");
        Console.WriteLine("8 = Inkrementieren und Dekrementieren");
        Console.WriteLine("9 = Potenzieren, Division und Modulo");
        Console.Write("Nummer: ");

        string auswahl = Console.ReadLine() ?? "";
        Console.WriteLine();

        switch (auswahl)
        {
            case "1":
                VariablenUndDatentypen.Main();
                break;
            case "2":
                EinfacheEingabeAusgabe.Main();
                break;
            case "3":
                FehlerFinden.Main();
                break;
            case "4":
                StringOperationen.Main();
                break;
            case "5":
                Nettolohn.Main();
                break;
            case "6":
                CodeLesen.Main();
                break;
            case "7":
                Grundrechenarten.Main();
                break;
            case "8":
                InkrementierenDekrementieren.Main();
                break;
            case "9":
                Modulo.Main();
                break;
            default:
                Console.WriteLine("Diese Uebung gibt es nicht.");
                break;
        }
    }
}
