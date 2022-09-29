using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] GameObject Exploitation;

    CountDownTimer destroyTimer;
    void Start()
    {
        destroyTimer=gameObject.AddComponent<CountDownTimer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (destroyTimer.finished)
        {
            Instantiate(Exploitation, gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
            destroyTimer.Run();

        }  
    }
    public void DestroyAstroid(int time)
    {
        destroyTimer.TotalTime = time;
        destroyTimer.Run();

    }
}
