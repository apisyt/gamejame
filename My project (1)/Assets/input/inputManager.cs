using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputManager : MonoBehaviour
{
    public static Vector2 Movment;
    private PlayerInput _playerInput;
    private InputAction _moveAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _moveAction = _playerInput.actions["Move"];
   
    }
    private void Update()
    {
        Movment = _moveAction.ReadValue<Vector2>();
    }
}
