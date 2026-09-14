using OperatorenVertiefung;

Eingabe.Start(() =>
{
    double geschwindigkeit = Eingabe.ReelleZahl("Durchschnittliche Geschwindigkeit (km/h): ");
    double verbrauch = Eingabe.ReelleZahl("Verbrauch (Liter pro 100 km): ", nullErlaubt: true);
    double distanz = Eingabe.ReelleZahl("Distanz (km): ", nullErlaubt: true);
    double minuten = distanz / geschwindigkeit * 60;
    double liter = distanz / 100 * verbrauch;
    Eingabe.Ergebnis("Fahrzeit", minuten, "Minuten");
    Eingabe.Ergebnis("Benzinverbrauch", liter, "Liter");
});
