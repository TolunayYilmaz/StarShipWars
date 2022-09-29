using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequentialDestroyer : MonoBehaviour
{
    [SerializeField]GameObject astroidPrefab;
    GameObject spaceShip;
    List<GameObject> astroidList;
    GameObject targetAstroid;
    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("Player");
        astroidList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            Vector3 positionGame = Camera.main.ScreenToWorldPoint(position);
            GameObject astroid = Instantiate(astroidPrefab, positionGame, Quaternion.identity);
            astroidList.Add(astroid);

        }
        if (Input.GetMouseButtonDown(1))
        {
            TargetDestroy();
        }
    }
    public void TargetDestroy()
    {
        targetAstroid = NearestAstroid();
        if(targetAstroid != null)
        {
            targetAstroid.GetComponent<DestroyObject>().DestroyAstroid(1);
            astroidList.Remove(targetAstroid);
        }
        
       
    }

    GameObject NearestAstroid()
    {
        GameObject nearestAsteroid;
        float nearestDistance;
        
        if (astroidList.Count == 0)
        {
            return null;
        }
        else
        {
            nearestAsteroid = astroidList[0];
            nearestDistance = DistanceObject(nearestAsteroid);
        }
        foreach (GameObject astroid in astroidList)
        {
            float distance =DistanceObject(astroid);    
            if(distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestAsteroid = astroid;
            }

        }
        return nearestAsteroid;  
    }

    float DistanceObject(GameObject target)
    {
        return Vector3.Distance(spaceShip.transform.position,target.transform.position);
    }
}
