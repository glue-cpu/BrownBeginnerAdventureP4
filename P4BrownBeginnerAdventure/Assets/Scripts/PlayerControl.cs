using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float horizontal = 0.0f;
    float vertical = 0.0f;
    void Update()
    {
        float position = transform.position;
        position.x = horizontal;
        position.y = vertical;
        transform.position = position;

        //This is the movement part of the script
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);

        if (Keyboard.current.upArrowKey.isPressed) { 
            vertical = 1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        Debug.Log(vertical);


        //Friction area---------------------
        
        //if the player has horizontal movement
        if (horizontal > 0.0f)
        {
            horizontal = horizontal - 0.001f;
        }
        //terminates horizontal movement if it's less than 0
        else if (horizontal <= 0.0f)
        {
            horizontal = 0.0f;
        }
    }
}
