using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Collider2D ball; 
    public bool isRight; 
    public ScoreManager manager;

    public Image backgroundKanan;
    public Image backgroundKiri;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball) 
        { 
            if (isRight) 
            { 
                manager.AddLeftScore(1);
                // parameter ganti warna Color(Red, Green, Blue, Alpha)
                backgroundKanan.color = backgroundKanan.color + new Color(0.2f, 0, 0, 1);
            } 
            else 
            { 
                manager.AddRightScore(1); 
                backgroundKiri.color = backgroundKiri.color + new Color(0, 0, 0.2f, 1);
            } 
        }
    }
}
