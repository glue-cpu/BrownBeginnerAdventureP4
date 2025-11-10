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
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody2d = GetComponent<Rigidbody2D>();
        //above, this is you left off.
        LeftAction.Enable();
        MoveAction.Enable();
    }
    
    public InputAction LeftAction;
    public InputAction MoveAction;
    
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 8.0f * Time.deltaTime;
        transform.position = position;
    }
}
