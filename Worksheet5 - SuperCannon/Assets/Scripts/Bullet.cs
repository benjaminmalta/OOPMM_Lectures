using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed;
    // Vector3 targetpos;

    private Vector2 direction;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
        //targetpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //targetpos = new Vector3(targetpos.x,targetpos.y,0);
        direction = GameData.Target - new Vector3(0f, -8f, 0f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
     
       
       
        
    }
}
