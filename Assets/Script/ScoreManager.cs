using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreRight, scoreLeft, maxScore;
    public BolaController bola;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void addScoreRight (int increment)
    {
        scoreRight += increment;
        bola.ResetBall();
        if(scoreRight >= maxScore)
        {
            gameOver();
        }

    }

    public void addScoreLeft (int increment)
    {
        scoreLeft += increment;
        bola.ResetBall();
        if(scoreLeft >= maxScore)
        {
            gameOver();
        }
    }

    public void gameOver ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
