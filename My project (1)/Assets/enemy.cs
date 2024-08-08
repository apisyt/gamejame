using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour
{
    public Transform Player;

    // Reference to the camera object
    public Transform Enemy;
    private float distance;

    public float Espeed = 3f;
    private Transform target;

    private void Update()
    {

        if (target != null )
        {
            distance = Vector2.Distance(Player.position, Enemy.position);
            float step = Espeed * Time.deltaTime * distance;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
            
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
          
        }


    }

}
