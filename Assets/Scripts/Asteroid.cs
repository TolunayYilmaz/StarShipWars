using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody2D asteroidRb;
    [SerializeField] GameObject exploxionAstroidPrefab;

    GameManager gameManager;
    void Start()
    {
        asteroidRb = GetComponent<Rigidbody2D>();
        gameManager=Camera.main.GetComponent<GameManager>();    
        RandomForce(asteroidRb);
    }



    void RandomForce(Rigidbody2D asteroidRb)
    {
        float direction = Random.Range(0, 2f);
        if (direction > 0.5f)
        {
            asteroidRb.AddForce(new Vector2(Random.Range(1,2f), Random.Range(-1f, -2f)), ForceMode2D.Impulse);
            asteroidRb.AddTorque(direction * 2f);
        }
        else
        {
            asteroidRb.AddForce(new Vector2(Random.Range(-1, -2f), Random.Range(-1f, -2f)), ForceMode2D.Impulse);
            asteroidRb.AddTorque(-direction * 2f);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("patladý");
            Destroy(other.gameObject);
            Instantiate(exploxionAstroidPrefab, transform.position, Quaternion.identity);
            gameManager.LevelUp(gameObject);
            Destroy(gameObject);  
        }
    }

}
