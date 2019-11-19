using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Shape
{
    // Start is called before the first frame update
    GameObject myballprefab;
    void Start()
    {
        Debug.Log(xpos);
        myballprefab = Resources.Load("Box") as GameObject;
        GameObject myboxshape= Instantiate(myballprefab, new Vector3(xpos,ypos,0),Quaternion.identity); 
        Rigidbody2D mybox = myboxshape.GetComponent<Rigidbody2D>() as Rigidbody2D;
        MoveLeft(mybox);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
