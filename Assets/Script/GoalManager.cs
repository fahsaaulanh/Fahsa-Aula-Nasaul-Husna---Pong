using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public bool isRight;
    public Collider2D bola;
    public ScoreManager managerScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == bola)
        {
            if(isRight)
            {
                managerScore.addScoreLeft(1);
            }
            else
            {
                managerScore.addScoreRight(1);
            }
        }
    }
}
