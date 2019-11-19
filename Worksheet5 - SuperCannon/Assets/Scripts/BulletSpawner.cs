using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject mysmallbullet;
    [SerializeField] GameObject mylargebullet;

    public static BulletSpawner _instance;  //Singleton holding an instance of the class

    private Coroutine sbc_running;
    private Coroutine lbc_running;


    private void Awake()  //Singleton method to destroy more than one BulletSpawner by checking if class instance already exists
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // mousepos = new Vector3(mousepos.x, mousepos.y, 0);
        

        var newRotation = Quaternion.LookRotation(transform.position - GameData.Target, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;

        transform.rotation = newRotation;  //**no slurp
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);


        if (Input.GetMouseButtonDown(0))
        {
            sbc_running = StartCoroutine(FireContinuously(mysmallbullet));
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine(sbc_running);
        }



        if (Input.GetMouseButtonDown(1))
        {
            lbc_running = StartCoroutine(FireContinuously(mylargebullet));
        }

        if (Input.GetMouseButtonUp(1))
        {
            StopCoroutine(lbc_running);
        }




    }


    IEnumerator FireContinuously(GameObject bullettype)
    {
        while (true)
        {
            Instantiate(bullettype, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }

    }
}
