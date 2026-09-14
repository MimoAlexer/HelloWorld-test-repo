using OperatorenVertiefung;

Eingabe.Start(() =>
{
    int x = 5;
    x++;
    Console.WriteLine($"Nach Erhöhen um 1: {x}");
    x--;
    x--;
    Console.WriteLine($"Nach Erniedrigen um 2: {x}");
});
