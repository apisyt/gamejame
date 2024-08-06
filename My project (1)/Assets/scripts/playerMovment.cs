using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5F;
    private Vector2 _movment;
    private Rigidbody2D _rb;
    private Animator _animator;

    private const string _horizontal = "ho";
    private const string _vertical = "ve";
    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        _movment.Set(inputManager.Movment.x, inputManager.Movment.y);
        _rb.velocity = _movment * _moveSpeed;
        _animator.SetFloat(_horizontal,_movment.x);
        _animator.SetFloat(_vertical, _movment.y);
    }
}
