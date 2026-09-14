public static class Grundrechenarten
{
    public static void Main()
    {
        Console.Write("Gib die erste Zahl ein: ");
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die zweite Zahl ein: ");
        double z2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addition: " + Math.Round(z1 + z2, 2));
        Console.WriteLine("Subtraktion: " + Math.Round(z1 - z2, 2));
        Console.WriteLine("Multiplikation: " + Math.Round(z1 * z2, 2));
        Console.WriteLine("Division: " + Math.Round(z1 / z2, 2));
    }
}
