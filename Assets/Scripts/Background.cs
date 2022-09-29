using UnityEngine;

public class Background : MonoBehaviour
{
   

    MeshRenderer mrBackground;
    void Start()
    {
        mrBackground = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = 0.1f * Time.time;
        mrBackground.material.SetTextureOffset("_MainTex", new Vector2(0, yAxis));
        
    }
}
