using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAtMouse : MonoBehaviour
{
    [SerializeField] GameObject myobject;
    Vector3 mypos = new Vector3();
    int count = 0;
  
    // Start is called before the first frame update
    void Start()
    {
      


    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Color.green,1);
        // Debug.Log(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
          //  Debug.Log("Left Mouse Button");


            //METHOD1
            
        //        mypos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10f);
       //         Instantiate(myobject, mypos, Quaternion.identity);
        //        count++;
               
            
            
            //METHOD2
              RaycastHit hit;
              Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                

            if (Physics.Raycast(ray, out hit))
                {
                Debug.Log("Ray cast" + hit.point);
                GameObject ballobject = Instantiate(myobject, hit.point, hit.transform.rotation) as GameObject;
             //   ballobject.GetComponent<Rigidbody2D>().velocity = new Vector2(20f,20f)*Time.deltaTime;
                count++;
                }
             

        

        }
    }
}
