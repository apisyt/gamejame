using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pickup : MonoBehaviour
{
    public int value = 1; // Wartoœæ pickupu

     private void OnTriggerEnter2D(Collider2D other)
    {
        // SprawdŸ, czy obiekt, który wszed³ w kolizjê, to gracz
        if (other.CompareTag("Player"))
        {
            // Dodaj wartoœæ do gracza
            other.GetComponent<PlayerInventory>().AddToInventory(value);

            // Zniszcz pickup
            Destroy(gameObject);

            Debug.Log("Wesz³o w kolizjê z: " + other.name);
    
    if (other.CompareTag("Player"))
    {
        Debug.Log("Zbieram przedmiot!");
    }
        }
    }
}