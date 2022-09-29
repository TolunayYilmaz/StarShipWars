using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenCalculator 
{
    static float left;
    static float right;
    static float top;
    static float bottom;    

    public  static float Left { get { return left; } }
    public static float Right { get { return right; } }
    public static float Top { get { return top; } }
    public static float Bottom { get { return bottom; } }
    public static void Init()
    {
        float zScreenAxis = -Camera.main.transform.position.z;
        Vector3 leftBottomCorner = new Vector3(0, 0, zScreenAxis);
        Vector3 rightTopCorner = new Vector3(Screen.width, Screen.height, zScreenAxis);

        Vector3 leftBottomCornerGameWorld = Camera.main.ScreenToWorldPoint(leftBottomCorner);
        Vector3 rightTopCornerGameWorld = Camera.main.ScreenToWorldPoint(rightTopCorner);

        left = leftBottomCornerGameWorld.x;
        right = rightTopCornerGameWorld.x;
        bottom = leftBottomCornerGameWorld.y;
        top = rightTopCornerGameWorld.y;
    }
 
}
