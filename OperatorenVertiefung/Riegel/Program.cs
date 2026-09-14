using OperatorenVertiefung;

Eingabe.Start(() =>
{
    const decimal preis = 3.20m;
    const decimal budget = 20m;
    int anzahl = (int)Math.Floor(budget / preis);
    decimal rest = budget % preis;
    Console.WriteLine($"Preis pro Riegel: {preis:F2} CHF");
    Console.WriteLine($"Budget: {budget:F2} CHF");
    Console.WriteLine($"Ganze Anzahl Riegel: {anzahl}");
    Console.WriteLine($"Restbetrag: {rest:F2} CHF");
});
