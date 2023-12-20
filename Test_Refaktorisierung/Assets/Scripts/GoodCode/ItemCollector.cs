using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class ItemCollector : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Vereinfachen Sie die Methode 'CollectItems' mithilfe eines Arrays und einer foreach-Schleife.
    - Refaktorisieren Sie den Code gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    private GameObject item1;
    private GameObject item2;
    private GameObject item3;
    private GameObject item4;
    private GameObject item5;
    private List<GameObject> collectedItems = new List<GameObject>();

    //public GameObject[] ItemArray = { item1, item2, item3, item4, item5 };
    public GameObject[] ItemArray;

    private void Start()
    {
        ItemArray = new GameObject[5];
    }

    void Update()
    {
        CollectItems();
    }

    void CollectItems()
    {
        foreach (GameObject item in ItemArray)
        {
            collectedItems.Add(item);
        }
    }
}
