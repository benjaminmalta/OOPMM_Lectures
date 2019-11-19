using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject myballprefab;
    // Start is called before the first frame update
    void Start()
    {
        myballprefab = Resources.Load("Ball") as GameObject;
        Instantiate(myballprefab, new Vector3(4f,4f,0),Quaternion.identity);
        Instantiate(myballprefab, new Vector3(-4f,4f,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
