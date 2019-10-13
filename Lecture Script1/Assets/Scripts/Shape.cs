using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected float xpos;
    protected float ypos;
    protected Vector2 speed;

 //   protected float Ypos { get => ypos; set => ypos = value; }

    public Shape()
       {
        xpos = -5;
        ypos = 0; 
        speed= new Vector2(5,0); 
       }

    protected void MoveRight(Rigidbody2D myshape)
    {
        myshape.velocity=speed;
    }

}
