using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquareVer2 : MonoBehaviour
{
    
    Vector3 mypos = new Vector3();

    private GameObject myprefab;
    // Start is called before the first frame update
    void Start()
    {
        myprefab = Resources.Load("Prefabs/Square") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
        mypos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10f);
        Instantiate(myprefab, mypos, Quaternion.identity);
        }
    }
}
