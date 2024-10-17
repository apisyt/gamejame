using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public TMP_Text inventoryText; // Referencja do komponentu TextMeshPro
    private int totalItems = 0; // Liczba przedmiotów w ekwipunku

    void Start()
    {
        UpdateInventoryText(); // Ustaw tekst na pocz¹tkow¹ wartoœæ
    }

    public void AddToInventory(int value)
    {
        totalItems += value; // Dodaj wartoœæ do totalItems
        Debug.Log("Zebrano Metal! £¹czna liczba: " + totalItems);
        UpdateInventoryText(); // Aktualizuj tekst po dodaniu
    }

    private void UpdateInventoryText()
    {
        // Ustaw tekst w TMP_Text na aktualn¹ liczbê przedmiotów
        inventoryText.text = "Metal: " + totalItems.ToString();
    }
}