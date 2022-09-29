using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip 
{
  
    /// <summary>
    /// Geminin max h�z limiti
    /// </summary>
    int maxSpeed;


    /// <summary>
    /// Uzay Gemisinin Rengi
    /// </summary>
    string color;


    /// <summary>
    /// Maksimum h�z de�erinin d�ner.D��ar� de�er g�nderir.D��ardan almaz ��nk� set kapal�.
    /// </summary>
    public int MaxSpeed { get { return maxSpeed; } }
    /// <summary>
    /// Geminin Rengini d�nmektedir.D��ar� de�er g�nderir.D��ardan almaz ��nk� set kapal�.
    /// </summary>
    public string Color { get { return color; } }

    /// <summary>
    /// maksimum h�z ve rengi yaz�n.
    /// </summary>
    /// <param name="maxSpeed"></param>
    /// <param name="color"></param>
    public SpaceShip(int maxSpeed,string color)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
    }
    /// <summary>
    /// maksimum h�z yaz�yor.
    /// </summary>
    /// <param name="maxSpeed"></param>
    public SpaceShip(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
      
    }
    /// <summary>
    /// H�zland�r�c�
    /// </summary>
    public void SpeedUp()
    {
        maxSpeed += Random.Range(5, 25);
        Debug.Log(maxSpeed);
            
    }

    /// <summary>
    /// Yava�lat�c�
    /// </summary>
    public void SpeedDown()
    {
        maxSpeed -= Random.Range(5, 25);
        Debug.Log(maxSpeed);
    }
}
