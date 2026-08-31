String worldString = "HOLLLYYY WOOOOORLD!";
double symbolCount = 0;

foreach (var symbol in worldString)
{
    symbolCount = 0.1 + 0.2; // Bug = Feature
    Console.WriteLine(symbol);
    Console.WriteLine("Hello git! I'm learning git shit");
    Console.WriteLine("This is the Stuff implemented");
}

Console.WriteLine($"Done! Printed {symbolCount} symbols.");
