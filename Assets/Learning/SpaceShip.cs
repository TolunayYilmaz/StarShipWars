using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip 
{
  
    /// <summary>
    /// Geminin max hýz limiti
    /// </summary>
    int maxSpeed;


    /// <summary>
    /// Uzay Gemisinin Rengi
    /// </summary>
    string color;


    /// <summary>
    /// Maksimum hýz deðerinin döner.Dýþarý deðer gönderir.Dýþardan almaz çünkü set kapalý.
    /// </summary>
    public int MaxSpeed { get { return maxSpeed; } }
    /// <summary>
    /// Geminin Rengini dönmektedir.Dýþarý deðer gönderir.Dýþardan almaz çünkü set kapalý.
    /// </summary>
    public string Color { get { return color; } }

    /// <summary>
    /// maksimum hýz ve rengi yazýn.
    /// </summary>
    /// <param name="maxSpeed"></param>
    /// <param name="color"></param>
    public SpaceShip(int maxSpeed,string color)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
    }
    /// <summary>
    /// maksimum hýz yazýyor.
    /// </summary>
    /// <param name="maxSpeed"></param>
    public SpaceShip(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
      
    }
    /// <summary>
    /// Hýzlandýrýcý
    /// </summary>
    public void SpeedUp()
    {
        maxSpeed += Random.Range(5, 25);
        Debug.Log(maxSpeed);
            
    }

    /// <summary>
    /// Yavaþlatýcý
    /// </summary>
    public void SpeedDown()
    {
        maxSpeed -= Random.Range(5, 25);
        Debug.Log(maxSpeed);
    }
}
