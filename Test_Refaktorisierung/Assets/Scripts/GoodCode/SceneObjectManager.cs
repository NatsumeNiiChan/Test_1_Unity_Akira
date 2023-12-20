using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class SceneObjectManager : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript, um alle Objekte mit dem Tag "Enemy" einem Array von Feinden und alle Objekte mit
      dem Tag "Item" einem Array von Gegenständen effizient hinzuzufügen.
    - Weisen Sie jedem "Enemy"-Objekt einen zufälligen Typ aus dem enemyTypes-Array zu.
    - Weisen Sie jedem "Item"-Objekt eine zufällige Position innerhalb des angegebenen itemPositionRange-Bereichs zu.
    - Erstellen Sie 2 Button Methoden, Button 1 soll jeden Enemy mit dem dazugehörigen Typ in die Console schreiben.
      Button 2 soll jedes Item mit der jeweilig dazugehörigen Position in die Console schreiben.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject[] items;
    [SerializeField] private string[] enemyTypes = { "fire", "water", "ice", "stone" };
    private Vector3 itemPositionRange = new Vector3(10f, 10f, 10f);

    private int enemyNumber = 6;
    private int itemNumber = 6;

    private void Start()
    {
        enemies = new GameObject[enemyNumber];
        for (int i = 0; i < enemyNumber; i++)
        {
            enemies[i] = GameObject.FindGameObjectWithTag("Enemy");
            enemies[i].tag = enemyTypes[Random.Range(0, 3)];
        }

        items = new GameObject[itemNumber];
        for (int i = 0; i < itemNumber; i++)
        {
            items[i] = GameObject.FindGameObjectWithTag("Item");
            items[i].tag = "positionedItem";
            items[i].transform.position = itemPositionRange;
        }
    }

    public void EnemyTypes()
    {
        if (enemies.Length > 0)
        {
            foreach (GameObject enemy in enemies)
            {
                Debug.Log(enemy.tag);
            }
        }

        else
        {
            Debug.Log("no Enemies");
        }
    }

    public void ItemPosition()
    {
        if (items.Length > 0)
        {
            foreach (GameObject item in items)
            {
                Debug.Log(item.transform.position);
            }

        }

        else
        {
            Debug.Log("no Items");
        }
    }
}
