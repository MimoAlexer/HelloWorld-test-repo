using OperatorenVertiefung;

Eingabe.Start(() =>
{
    int stunden = Eingabe.Ganzzahl("Stunden: ");
    int minuten = Eingabe.Ganzzahl("Minuten (0–59): ", 59);
    int sekunden = Eingabe.Ganzzahl("Sekunden (0–59): ", 59);
    double dezimalstunden = stunden + minuten / 60.0 + sekunden / 3600.0;
    Console.WriteLine($"{stunden} Stunden, {minuten} Minuten, {sekunden} Sekunden");
    Eingabe.Ergebnis("Dezimalstunden", dezimalstunden, "Stunden", 6);
});
