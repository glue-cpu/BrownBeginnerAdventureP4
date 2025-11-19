using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Object: " + other);
        PlayerControl controller = other.GetComponent<PlayerControl>();
        if (controller != null)
        {
            if (controller.currentHealth != 0)
            {
                controller.ChangeHealth(-1);
            }
        }
    }
}
