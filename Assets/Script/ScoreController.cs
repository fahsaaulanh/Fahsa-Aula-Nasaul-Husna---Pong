using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKanan;
    public Text skorKiri;

    public ScoreManager managerSkor;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        skorKanan.text = managerSkor.scoreRight.ToString();
        skorKiri.text = managerSkor.scoreLeft.ToString();
    }
}
