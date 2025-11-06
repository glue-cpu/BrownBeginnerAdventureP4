using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction LeftAction;
    public InputAction MoveAction;
}

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 900;
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
