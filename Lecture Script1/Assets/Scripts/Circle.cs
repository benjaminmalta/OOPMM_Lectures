using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    // Start is called before the first frame update
    GameObject myballprefab;
    void Start()
    {
        Debug.Log(xpos);
        myballprefab = Resources.Load("Ball") as GameObject;
        GameObject myball= Instantiate(myballprefab, new Vector3(xpos,ypos,0),Quaternion.identity); 
        Rigidbody2D mycircle = myball.GetComponent<Rigidbody2D>() as Rigidbody2D;
        MoveRight(mycircle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
