using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pickup : MonoBehaviour
{
    public int value = 1; // Warto�� pickupu

     private void OnTriggerEnter2D(Collider2D other)
    {
        // Sprawd�, czy obiekt, kt�ry wszed� w kolizj�, to gracz
        if (other.CompareTag("Player"))
        {
            // Dodaj warto�� do gracza
            other.GetComponent<PlayerInventory>().AddToInventory(value);

            // Zniszcz pickup
            Destroy(gameObject);

            Debug.Log("Wesz�o w kolizj� z: " + other.name);
    
    if (other.CompareTag("Player"))
    {
        Debug.Log("Zbieram przedmiot!");
    }
        }
    }
}