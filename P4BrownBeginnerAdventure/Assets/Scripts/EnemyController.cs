using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool vertical;
    public float speed;
    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (vertical)
        {
            position.y = position.y + speed * Time.deltaTime * direction;
        }
        else
        {
            position.x = position.x + speed * Time.deltaTime * direction;
        }
        rigidbody2d.MovePosition(position);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
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
