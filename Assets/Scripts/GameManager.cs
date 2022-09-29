using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject spaceShip;
    [SerializeField] List<GameObject> asteroidPrefabs= new List<GameObject>();   
    List<GameObject> asteroids = new List<GameObject>();
    [SerializeField] int difficulty;//zorluk
    void Start()
    {
        Instantiate(spaceShip);
        spaceShip.transform.position = new Vector3(0, ScreenCalculator.Bottom + 1.5f);
        SpawnAsteroid(3);
    }

    void SpawnAsteroid(int pieces) 
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < pieces; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x=Random.Range(ScreenCalculator.Left,ScreenCalculator.Right);
            position.y = ScreenCalculator.Top - 1.5f;
          
            GameObject asteroid=Instantiate(asteroidPrefabs[Random.Range(0,3)],position,Quaternion.identity);
            asteroids.Add(asteroid);

        }
    
    
    }
    public void LevelUp(GameObject astroid)
    {
        asteroids.Remove(astroid);
        if (asteroids.Count == 0)
        {
            difficulty++;
            SpawnAsteroid(difficulty);
            
        }
    }

}
