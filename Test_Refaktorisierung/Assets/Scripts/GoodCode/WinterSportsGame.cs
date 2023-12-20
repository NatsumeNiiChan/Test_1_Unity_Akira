using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterSportsGame : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Achten Sie auf die konsistente Benennung von Variablen und Methoden.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    //Festlegung von Variablen und erstellen einer Liste
    public List<string> Achievements = new List<string>();

    [SerializeField] private GameObject ski;
    [SerializeField] private int playerStamina = 100;
    [SerializeField] private float speed = 10f;
    private bool isSkiing;

    void Start()
    {
        //Staminawert wird festgelegt + Konsolennachricht
        playerStamina = 100;
        Debug.Log("WinterSports beginnt!");
    }

    void Update()
    {
        //Abfrage ob der Spieler noch Stamina hat, dann Ausführung von Methoden, sonst Konsolennachricht
        if (playerStamina > 0)
        {
            CheckSkiing();
            CheckAchievements();
        }
        
        else
        {
            Debug.Log("Spiel beendet!");
        }
    }
    void CheckSkiing()
    {
        //Wenn isSkiing true ist wird eine Bewegungsberechnung gestartet, sonst Konsolennachricht
        if (isSkiing)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            ski.transform.Translate(move * speed * Time.deltaTime);
        }
        
        else
        {
            Debug.Log("Spieler kann nicht Ski fahren!");
        }
    }

    void CheckAchievements()
    {
        //Abfrage ob es Achievements gibt -> Konsolennachricht mit den Achivements
        if (Achievements.Count == 0)
        {
            Debug.Log("Keine Erfolge erzielt.");
        }
        
        else
        {
            foreach (var achievement in Achievements)
            {
                Debug.Log("Erfolg: " + achievement);
            }
        }
    }

    public void LoseStamina(int amount) //wird in diesem Script nicht verwendet
    {
        //Staminawert wird verändert, kann nicht unter 0 fallen
        playerStamina -= amount;

        if (playerStamina < 0)
        {
            playerStamina = 0;
        }
    }

    public void AddAchievement(string achievement) //wird in diesem Script nicht verwendet
    {
        //fügt Achievements hinzu wenn es keine gibt
        if (!Achievements.Contains(achievement))
        {
            Achievements.Add(achievement);
        }
    }

    public void StartSkiing() //wird in diesem Script nicht verwendet
    {
        //setzt den Bool auf true
        isSkiing = true;
    }

    public void StopSkiing() //wird in diesem Script nicht verwendet
    {
        //setzt den Bool auf false
        isSkiing = false;
    }
}
