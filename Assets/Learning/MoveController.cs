using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    float colliderHalfHeight;
    float colliderHalfWidht;
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5, 5)),ForceMode2D.Impulse);
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        colliderHalfHeight = boxCollider.size.y / 2;
        colliderHalfWidht = boxCollider.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = Input.mousePosition;
        //position.z=-Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        //transform.position= position;
        //Boundry();
    }
    void Boundry()
    {
        Vector3 position = transform.position;
        if (position.x - colliderHalfWidht < ScreenCalculator.Left)
        {
            position.x = ScreenCalculator.Left + colliderHalfWidht;
        }
        else if (position.x + colliderHalfWidht > ScreenCalculator.Right)
        {
            position.x = ScreenCalculator.Right - colliderHalfWidht;
        }
        if (position.y + colliderHalfHeight > ScreenCalculator.Top)
        {
            position.y = ScreenCalculator.Top - colliderHalfHeight;
        }
        else if (position.y - colliderHalfHeight < ScreenCalculator.Bottom)
        {
            position.y = ScreenCalculator.Bottom + colliderHalfHeight;
        }
       
        transform.position= position;
    }
}
