using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField]GameObject astroidPrefab;
    CountDownTimer countDownTimer;
    
    // Start is called before the first frame update
    void Start()
    {   
        countDownTimer=gameObject.AddComponent<CountDownTimer>();

        countDownTimer.TotalTime = 1;
        countDownTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (countDownTimer.finished)
        {
            spawnAstroid();
            countDownTimer.Run();
        }
    }
    void spawnAstroid()
    {
        Instantiate(astroidPrefab);
    }
  
}
