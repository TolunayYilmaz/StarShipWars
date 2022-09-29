using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
   [SerializeField]GameObject starPrefab;

    List<GameObject> stars =new List<GameObject>();

    /// <summary>
    /// Hedefteki yýldýzý söyler
    /// </summary>
   public GameObject TargetStar
    {
        get
        {
            if (stars.Count > 0)
            {
                return stars[0];
            }
            else
            {
                return null;
            }
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            Vector3 gamePos = Camera.main.ScreenToWorldPoint(pos);
            stars.Add(Instantiate(starPrefab,gamePos,Quaternion.identity));
        }
    }

    public void DestroyStar(GameObject DestroyStar)
    {
        stars.Remove(DestroyStar);//yok edilecek yýldýz
        Destroy(DestroyStar);
    }
}
