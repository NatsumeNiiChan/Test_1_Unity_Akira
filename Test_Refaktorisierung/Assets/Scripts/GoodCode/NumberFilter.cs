using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class NumberFilter : MonoBehaviour
{
    /*
   Aufgabenstellung: Refaktorisierung

   - Refaktorisieren Sie das Skript, um die Zahlenreihe effizienter nach geraden und ungeraden Zahlen zu filtern.
   - Nutzen Sie Arrays und foreach-Schleifen für die Refaktorisierung.
   - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
   - Fügen Sie zwei Methoden hinzu, die jeweils alle geraden bzw. ungeraden Zahlen lesbar in die Konsole schreiben.
   - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
   - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
   */

    public int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public int[] evenNumbers;
    public int[] oddNumbers;
    //private int Sort;
    //private string Number;

    //private void Start()
    //{
    //    List<int> numbers = new List<int> { new int { Sort = 1 }, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //    var sortedByEven = numbers.OrderBy(n => n.Sort);
    //}
}
