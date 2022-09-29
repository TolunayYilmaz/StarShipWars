using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D bulletrigidbody2D;
    CountDownTimer timer;
    void Start()
    {
        bulletrigidbody2D = GetComponent<Rigidbody2D>();
        bulletrigidbody2D.AddForce(Vector2.up *10f,ForceMode2D.Impulse);
        timer=gameObject.AddComponent<CountDownTimer>();
        timer.TotalTime = 3;
        timer.Run();    
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.finished)
        {
            Destroy(gameObject);
            
        }
        
    }
}
