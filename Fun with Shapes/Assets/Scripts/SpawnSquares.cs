using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquares : MonoBehaviour
{
    [SerializeField] GameObject squarePrefab;
    [SerializeField] float padding;
     List<Vector2> positions = new List<Vector2>();
    float XMin, XMax, YMin, YMax;
    float timer=0;
    
    Vector2 newposition = new Vector2();
    // Start is called before the first frame update
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
    //    for (int k=0; k<10; k++)
 //       {
  //          positions.Add(new Vector2(Random.Range(XMin, XMax), Random.Range(YMin, YMax)));
  //          Instantiate(squarePrefab, new Vector3(positions[k].x, positions[k].y, 0), Quaternion.identity);
  //      }
    }

    // Update is called once per frame
    void Update()
    {
       
    //    Debug.Log(timer);
        timer+=Time.deltaTime*1000;
        if ((int)(timer)%100==0) 
            {
                newposition = new Vector2(Random.Range(XMin, XMax), Random.Range(YMin, YMax));
                Instantiate(squarePrefab, new Vector3(newposition.x , newposition.y, 0), Quaternion.identity);
            }
    }
}
