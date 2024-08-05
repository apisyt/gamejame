using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5F;
    private Vector2 _movment;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _movment.Set(inputManager.Movment.x, inputManager.Movment.y);
        _rb.velocity = _movment * _moveSpeed;
    }
}
