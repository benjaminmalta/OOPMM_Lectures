using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    MyGameManager GameManager;
    [SerializeField] int enemypoints = 0;
    //Transform bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<MyGameManager>();
        

    }

     public void OnCollisionEnter2D(Collision2D other){

        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Debug.Log("collision");
            GameManager.IncreaseScore(enemypoints);
        }
      
   }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(other.gameObject);
        }

    }

}
