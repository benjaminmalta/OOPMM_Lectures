using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircles : MonoBehaviour
{
    // Start is called before the first frame update
    
    float XMin,XMax,YMin,YMax;
    public float padding=0;

    public GameObject myprefab;
    void Start()
    {
        Camera gameCamera = Camera.main;
        XMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        Debug.Log(XMin);
        XMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        Debug.Log(XMax);
        YMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        Debug.Log(YMin);
        YMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
        Debug.Log(YMax);

        Instantiate(myprefab, new Vector3(XMin,YMax,0), Quaternion.identity);



        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
