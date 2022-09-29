using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    float force = 10f;
    bool collecting = false; //topluyor

    GameObject target; // hedef
    Rigidbody2D myRigidbody2D;
    Collector collector;


    // Update is called once per frame
    void Update()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        collector = Camera.main.GetComponent<Collector>();
    }

    private void OnMouseDown()
    {
        if (!collecting)
        {
            GoCollect();
        }
    }
    void GoCollect()
    {
        target = collector.TargetStar;
        if (target != null)
        {
            Vector2 targetRange = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y);
            targetRange.Normalize();
            myRigidbody2D.AddForce(targetRange * force, ForceMode2D.Impulse);

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject == target)
        {
            collector.DestroyStar(target);
            myRigidbody2D.velocity = Vector2.zero;//hýzý sýfýrlar
            GoCollect();// baþka yýldýzlar varsa git ve topla
        }
    }

    void ShipControl()
    {
        Vector3 position = transform.position;
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        if (verticalInput != 0)
        {
            position.y += verticalInput * force * Time.deltaTime;
        }
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * force * Time.deltaTime;
        }
        transform.position = position;
    }
}
