public static class VariablenUndDatentypen
{
    public static void Main()
    {
        int ganzzahl = 10;
        double kommazahl = 3.14;
        string text = "Hallo";

        Console.WriteLine(ganzzahl.GetType());
        Console.WriteLine(kommazahl.GetType());
        Console.WriteLine(text.GetType());
    }
}
