using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction LeftAction;
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
}

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        LeftAction.Enable();
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    
    public InputAction LeftAction;
    public InputAction MoveAction;
    
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
    }

    void FixedUpdate()
    {
         Vector2 position = (Vector2)rigidbody2d.position + move * 6.5f * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}
