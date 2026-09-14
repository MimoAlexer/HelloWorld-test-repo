using OperatorenVertiefung;

Eingabe.Start(() =>
{
    decimal a = Eingabe.Dezimalzahl("Erste Zahl: ");
    decimal b = Eingabe.Dezimalzahl("Zweite Zahl: ");
    Console.WriteLine($"Addition: {Math.Round(a + b, 2, MidpointRounding.AwayFromZero):F2}");
    Console.WriteLine($"Subtraktion: {Math.Round(a - b, 2, MidpointRounding.AwayFromZero):F2}");
    Console.WriteLine($"Multiplikation: {Math.Round(a * b, 2, MidpointRounding.AwayFromZero):F2}");
    if (b != 0)
        Console.WriteLine($"Division: {Math.Round(a / b, 2, MidpointRounding.AwayFromZero):F2}");
    else
        Console.WriteLine("Division durch 0 ist nicht möglich.");
    Console.WriteLine("Wissen: int / int entfernt Nachkommastellen (5 / 2 = 2).");
    Console.WriteLine("Mit decimal bleiben Nachkommastellen erhalten (5 / 2.0m = 2.5).");
});
