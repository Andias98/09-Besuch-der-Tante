# Besuch bei der Lieblingstante

## Lehrziele:
    
    Umwandeln von Zeichenketten in Gleitkommazahlen (ohne Fehlerbehandlung)
    Umwandlung Gleitkommazahlen in Ganzzahlen
    Einfache Verzweigungen (optional)

## Aufgabenstellung

Sie fahren am Vormittag (10:00 Uhr) mit dem Rad zu ihrer Lieblingstante. Die Entfernung zur Tante muss eingegeben werden. Ihr Programm soll in Abhängigkeit der gleichmäßig gefahrenen Geschwindigkeit (Gleitkommazahl in km/h) berechnen, wann Sie bei der Tante ankommen.

Sie werden eine double-Variable in den nächstkleineren int-Wert abrunden müssen. **Dazu ein kleines Codefragment als Hinweis:**

      double doubleValue;
      int nextLowerIntValue;
      int nextHigherIntValue;
      doubleValue = 12.3456;
      nextLowerIntValue = (int)Math.Floor(doubleValue);
      nextHigherIntValue = (int)Math.Ceiling(doubleValue);

Machen Sie für folgende Testfälle den Schreibtischtest, bevor Sie mit dem Programmieren beginnen:

![274438373-614a5048-7784-4c31-9604-8a7fdd2389c2](https://github.com/Andias98/09-Besuch-der-Tante/assets/145590196/d39a01cd-fba5-4243-8c0a-a5fd0728ac66)


## Erweiterte Anforderungen für Spezialisten
Kommen Sie vor 12:00 Uhr bei der Tante an, bekommen Sie noch ein Mittagessen, sonst gibt es nurKaffee und Kuchen. Geben Sie den entsprechenden Text aus.
Wenn die eingegebene Geschwindigkeit nicht reicht, um die Tante vor 19:00 Uhr zu erreichen, geben Sie eine Warnung aus, dass es dunkel wird, bevor Sie die Tante erreichen.
Lassen Sie den Benutzer bei Programmbeginn entscheiden, ob er die Fahrtdauer oder die Geschwindigkeit vorgeben will und berechnen Sie die jeweils andere Komponente. Unterstützung von Mitschülern, die mit der Übung noch nicht so weit sind.

