using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{

    void Start()
    {
        SpaceShip gemi1 = new SpaceShip(Random.Range(0, 10));
        SpaceShip gemi2 = new SpaceShip(Random.Range(0, 10));
        gemi1.SpeedUp();
        gemi2.SpeedUp();

        if (gemi1.MaxSpeed < gemi2.MaxSpeed)
        {
            Debug.Log("Gemi2 Kazand�");
        }
        else if (gemi1.MaxSpeed > gemi2.MaxSpeed)
        {
            Debug.Log("Gemi1 Kazand�");
        }
        else
        {
            Debug.Log("Berabere");
        }
        gemi1.SpeedDown();
        gemi2.SpeedDown();
    }

}
