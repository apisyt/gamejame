using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int totalItems = 0; // Liczba przedmiot�w w ekwipunku

    public void AddToInventory(int value)
    {
        totalItems += value;
        Debug.Log("Zebrano Metal! ��czna liczba: " + totalItems);
    }
}