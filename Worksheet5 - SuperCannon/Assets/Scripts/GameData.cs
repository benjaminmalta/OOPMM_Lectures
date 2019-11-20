using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    // Start is called before the first frame update

    private static int _score = 0;
    


    public static int Score
    {
        get { return _score; }
        set { _score = value; }
    }



    public static Vector3 Target  //PROPERTY - GETTER, SETTER OR BOTH
    {
        get { return GetTarget(); }  //GETTER (READ-ONLY)
        //  set { mousepos = value;  }  //TO CREATE A SETTER (READ & WRITE)
    }

    private static Vector3 GetTarget()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos = new Vector3(mousepos.x, mousepos.y, 0);
        return mousepos;

    }


    public static float XMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }


    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }



}
