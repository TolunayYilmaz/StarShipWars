using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
 
    float totalTime;
    float passingTime;
    bool work=false;
    bool start=false;
   /// <summary>
   /// Geri Sayým sayacýnýn toplam süresini ayarlar.
   /// </summary>
    public float TotalTime
    {
        set
        {
            if (!work)
            {
                totalTime = value;
            }

        }
    }
  /// <summary>
  /// Geri Sayýmýn bitip bitmediðini söyler.
  /// </summary>
    public bool finished
    {
        get { return start&&!work; }
    }
    /// <summary>
    /// Sayacý Çalýþtýrýr
    /// </summary>
    public void Run()
    {
        if(totalTime > 0)
        {
            work = true;
            start = true;
            passingTime = 0;
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (work)
        {
            passingTime+=Time.deltaTime;    
            if(passingTime >= totalTime)
            {
                work=false;
            }
        }

    }
}
