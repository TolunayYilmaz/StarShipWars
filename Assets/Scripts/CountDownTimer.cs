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
   /// Geri Say�m sayac�n�n toplam s�resini ayarlar.
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
  /// Geri Say�m�n bitip bitmedi�ini s�yler.
  /// </summary>
    public bool finished
    {
        get { return start&&!work; }
    }
    /// <summary>
    /// Sayac� �al��t�r�r
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
