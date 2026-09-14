using OperatorenVertiefung;

Eingabe.Start(() =>
{
    decimal a = Eingabe.Dezimalzahl("Erste Zahl: ");
    decimal b = Eingabe.Dezimalzahl("Zweite Zahl: ");
    if (a > b)
        Console.WriteLine("Die erste Zahl ist grösser als die zweite.");
    else if (a == b)
        Console.WriteLine("Die Zahlen sind gleich.");
    else
        Console.WriteLine("Die zweite Zahl ist grösser als die erste.");
    Console.WriteLine("Wissen: 5 < 10 liefert den bool-Wert true (wahr).");
});
