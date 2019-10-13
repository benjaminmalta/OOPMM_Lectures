using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithKeys : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject myPrefab, myShape;
    void Start()
    {
        myPrefab=Resources.Load("Prefabs/Circle") as GameObject;
        myShape=Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            Debug.Log("key pressed");
            myShape.transform.position = new Vector3(myShape.transform.position.x+1, myShape.transform.position.y,0) ;
        }
    }

}
