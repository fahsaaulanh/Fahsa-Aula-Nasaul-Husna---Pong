using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public Collider2D bola;
    public float magnitude;
    public PowerUpManager manager;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola)
        {
            bola.GetComponent<BolaController>().ActivatePUPseedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
