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
    public int maxHealth = 5;
    int currentHealth;
}

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public int maxHealth = 5;
    int currentHealth;
    public float speed = 6.5f;
    // Start is called before the first frame update
    void Start()
    {
        LeftAction.Enable();
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }
    
    public InputAction LeftAction;
    public InputAction MoveAction;
    
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        ChangeHealth(1);
    }

    void FixedUpdate()
    {
         Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    void ChangeHealth (int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

}
