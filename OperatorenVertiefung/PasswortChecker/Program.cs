using OperatorenVertiefung;

Eingabe.Start(() =>
{
    string passwort = Eingabe.Text("Passwort: ");
    if (passwort.Length > 8)
        Console.WriteLine("Das Passwort ist länger als 8 Zeichen.");
    else
        Console.WriteLine("Das Passwort ist zu kurz: mindestens 9 Zeichen sind nötig.");
});
