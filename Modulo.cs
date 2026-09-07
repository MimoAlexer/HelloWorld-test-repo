public static class Modulo
{
    public static void Main()
    {
        double preis = 3.20;
        double geld = 20.00;

        int anzahlRiegel = (int)(geld / preis);
        double restgeld = geld % preis;

        Console.WriteLine("Du kannst " + anzahlRiegel + " Riegel kaufen.");
        Console.WriteLine("Restgeld: " + Math.Round(restgeld, 2) + " Franken");
    }
}
