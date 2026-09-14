using OperatorenVertiefung;

Eingabe.Start(() =>
{
    double gewicht = Eingabe.ReelleZahl("Gewicht (kg): ");
    double groesse = Eingabe.ReelleZahl("Grösse (m, z. B. 1.75): ");
    double bmi = gewicht / Math.Pow(groesse, 2);
    Eingabe.Ergebnis("BMI", bmi, "kg/m²");
});
