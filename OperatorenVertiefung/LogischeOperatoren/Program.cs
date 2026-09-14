using OperatorenVertiefung;

Eingabe.Start(() =>
{
    decimal zahl = Eingabe.Dezimalzahl("Zahl: ");
    if (zahl >= 10 && zahl <= 20)
        Console.WriteLine("Die Zahl liegt zwischen 10 und 20 (einschliesslich Grenzen).");
    else
        Console.WriteLine("Die Zahl liegt nicht zwischen 10 und 20.");
    if (zahl < 0 || zahl > 100)
        Console.WriteLine("Die Zahl ist kleiner als 0 oder grösser als 100.");
    else
        Console.WriteLine("Die Zahl liegt zwischen 0 und 100 (einschliesslich Grenzen).");
    Console.WriteLine("Wissen: && ist wahr, wenn beide Bedingungen wahr sind.");
    Console.WriteLine("|| ist wahr, wenn mindestens eine Bedingung wahr ist.");
});
