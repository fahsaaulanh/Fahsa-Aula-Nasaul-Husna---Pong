using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rb;

    public Vector2 resetPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

   
    void Update()
    {
        
    }

    public void ResetBall ()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUPseedUp(float magnitude)
    {
        rb.velocity *= magnitude;
    }
}
