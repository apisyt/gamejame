using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public TMP_Text inventoryText; // Referencja do komponentu TextMeshPro
    private int totalItems = 0; // Liczba przedmiot�w w ekwipunku

    void Start()
    {
        UpdateInventoryText(); // Ustaw tekst na pocz�tkow� warto��
    }

    public void AddToInventory(int value)
    {
        totalItems += value; // Dodaj warto�� do totalItems
        Debug.Log("Zebrano Metal! ��czna liczba: " + totalItems);
        UpdateInventoryText(); // Aktualizuj tekst po dodaniu
    }

    private void UpdateInventoryText()
    {
        // Ustaw tekst w TMP_Text na aktualn� liczb� przedmiot�w
        inventoryText.text = "Metal: " + totalItems.ToString();
    }
}