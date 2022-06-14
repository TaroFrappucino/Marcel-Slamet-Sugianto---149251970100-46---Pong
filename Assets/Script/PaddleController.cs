using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move Object
        moveObject(getInput());
    }

    // Terima input
    private Vector2 getInput() 
    {
        if (Input.GetKey(upKey)) {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey)) {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void moveObject(Vector2 movement) 
    {
        // Debug.Log("Speed paddle: " + movement);
        rig.velocity = movement;
    }
}
