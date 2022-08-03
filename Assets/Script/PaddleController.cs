using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upkey, downkey;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    public Vector2 GetInput ()
    {
        
        if (Input.GetKey(upkey))
        {
           return Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;

    }

    public void MoveObject(Vector2 movement)
    {
        rb.velocity = movement;
    }
}
