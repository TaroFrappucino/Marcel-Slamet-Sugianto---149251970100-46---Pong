using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;

    public Vector2 resetPosition;
    private int direction = 0;

    // Start is called before the first frame update
    // Fungsi yang otomatis dijalankan pada saat Game Object diaktifkan pertama kali, baik langsung saat game dijalankan, saat scene diload, atau diaktifkan manual dengan menggunakan script 
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
        rig.velocity = speed;
    }

    // Update is called once per frame
    // Fungsi yang otomatis dijalankan berulang-ulang selama Game Object aktif setelah Start dijalankan. Jika game object selalu aktif, maka fungsi ini akan berjalan terus menerus selama game berjalan. Lebih tepatnya fungsi ini dijalankan tiap Frame.
    void Update()
    {
        // Mengubah posisi objek
        // Vector3 (sb x, sb y, sb z)
        // Deltatime untuk mengatur perubahan posisi bola menggunakan per 1 detik dengan cara mengalikannya dengan waktu yang dibutuhkan untuk menjalankan 1 frame
        // Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);

        // fungsi Translate untuk memindah objek secara langsung daripada menggunakan transform.position
        // transform.Translate(speed * Time.deltaTime);
    }
   
    public void ResetBall() 
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        
        if (direction == 0)
        {
            speed = new Vector2(speed.x + 1, speed.y + 1);
            // rig.velocity = new Vector2(speed.x + 1, speed.y + 1);
            direction = 1;
        } else {
            rig.velocity = new Vector2((speed.x + 1) * -1, (speed.y + 1) * -1);
            direction = 0;
        }
    }
}
