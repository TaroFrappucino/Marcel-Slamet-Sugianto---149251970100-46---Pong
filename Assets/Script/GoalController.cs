using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Collider2D ball; 
    public bool isRight; 
    public ScoreManager manager;

    public GameObject paddleKanan;
    public GameObject paddleKiri;
    public Image backgroundKanan;
    public Image backgroundKiri;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            if (isRight) 
            { 
                manager.AddLeftScore(1);
                // parameter ganti warna Color(Red, Green, Blue, Alpha)
                backgroundKiri.color = backgroundKiri.color + new Color(0, 0, 0.2f, 1);
                paddleKiri.transform.localScale = new Vector2(0.6516581f, 3.33699f);
                paddleKanan.transform.localScale = new Vector2(0.6516581f, 3.33699f);
            } 
            else 
            { 
                manager.AddRightScore(1); 
                backgroundKanan.color = backgroundKanan.color + new Color(0.2f, 0, 0, 1);
                paddleKiri.transform.localScale = new Vector2(0.6516581f, 3.33699f);
                paddleKanan.transform.localScale = new Vector2(0.6516581f, 3.33699f);
            }
        }
    }
}
