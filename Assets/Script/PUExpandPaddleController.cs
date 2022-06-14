using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExpandPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Rigidbody2D ball;
    public GameObject paddleKanan;
    public GameObject paddleKiri;

    private void OnTriggerEnter2D(Collider2D collision) {
        Vector2 temp = ball.GetComponent<Rigidbody2D>().velocity;
        Debug.Log("isRight: " + temp.x);

        if (collision == ball)
        {
            if (temp.x >= 0)
            {
                paddleKiri.transform.localScale = new Vector2(paddleKiri.transform.localScale.x, (paddleKiri.transform.localScale.y + 0.45f));
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                paddleKanan.transform.localScale = new Vector2(paddleKanan.transform.localScale.x, (paddleKanan.transform.localScale.y + 0.45f));
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}