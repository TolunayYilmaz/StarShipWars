using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] GameObject astroidPrefab;

    List<GameObject> astroids =new List<GameObject>();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z=-Camera.main.transform.position.z;
            pos=Camera.main.ScreenToWorldPoint(pos);
            for (int i = 0; i < 20; i++)
            {
                astroids.Add(Instantiate(astroidPrefab, pos, Quaternion.identity));
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            foreach (GameObject go in astroids)
            {
                
                Destroy(go);
               
            }
            astroids.Clear();
        }
    }
   
}
