# Operatoren & Vertiefung

Neue .NET-10-Solution mit zehn unabhängig startbaren Konsolenprojekten.

| Übung | Projekt | Inhalt |
| --- | --- | --- |
| 1 | CodeLesen | Ganzzahldivision: 5 / 2 ergibt 2 |
| 2 | Grundrechenarten | Vier Rechenarten, Rundung auf zwei Stellen und Wissensfrage |
| 3 | InkrementierenDekrementieren | 5 um 1 erhöhen, dann um 2 erniedrigen |
| 4 | Riegel | 3.20 CHF pro Riegel, 20 CHF Budget, Floor und Modulo |
| 5 | Vergleichsoperatoren | Zwei Zahlen vergleichen und Wissensfrage |
| 6 | LogischeOperatoren | UND, ODER und Wissensfrage |
| 7 | PasswortChecker | Passwortlänge strikt grösser als 8 |
| 8 | Unterwegs | Fahrzeit in Minuten und Benzinverbrauch |
| 9 | BodyMassIndex | Gewicht / Math.Pow(Grösse in Metern, 2) |
| 10 | AroundTheClock | Stunden + Minuten / 60.0 + Sekunden / 3600.0 |

## Bauen und starten

Im Ordner dieser README:

```powershell
dotnet build OperatorenVertiefung.sln
dotnet run --project Riegel/Riegel.csproj
dotnet run --project BodyMassIndex/BodyMassIndex.csproj
```

In Rider die neue Solution öffnen und das gewünschte Projekt starten.

## Eingaben und Berechnungen

- Die gemeinsame Datei Gemeinsam/Eingabe.cs wird in jedes Projekt eingebunden.
- TryParse prüft Zahlen; bei ungültigen Eingaben wird erneut gefragt.
- Dezimalpunkt und Dezimalkomma sind erlaubt, Tausendertrennzeichen nicht.
- Geld und Grundrechenarten verwenden decimal; physikalische Grössen und Dezimalstunden double.
- Division durch null wird abgefangen. Geschwindigkeit, Gewicht und Grösse müssen positiv sein.
- Distanz und Benzinverbrauch dürfen null sein. NaN und Unendlich werden abgewiesen.
- Stunden sind nichtnegative Ganzzahlen; Minuten und Sekunden liegen zwischen 0 und 59.
- Bei Übung 6 zählen 10 und 20 zum Bereich.
- Ergebnisse werden mit Math.Round und MidpointRounding.AwayFromZero gerundet.
  Math.Round ohne diesen Parameter verwendet bei exakten Mittelpunkten standardmässig ToEven
  (zum Beispiel 2.5 → 2 und 3.5 → 4).
- Ein Eingabeende beendet das Programm kontrolliert; ein numerischer Überlauf wird gemeldet.
- Der BMI wird auf zwei Nachkommastellen ausgegeben, ohne medizinische Bewertung.
- Der Passwort-Checker prüft ausschliesslich die verlangte Länge.

Beispiele: 6 Riegel und 0.80 CHF Rest; 150 km bei 100 km/h und 6 l/100 km
ergeben 90 Minuten und 9 Liter; 70 kg bei 1.75 m ergeben BMI 22.86;
5 Stunden, 30 Minuten und 0 Sekunden ergeben 5.500000 Stunden.

Die Projekte HelloWorld und OperatorenVertiefung liegen in separaten Ordnern nebeneinander im gemeinsamen Git-Repository.
