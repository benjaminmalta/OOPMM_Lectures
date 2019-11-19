using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    //Transform bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //var bullet = Instantiate(bulletPrefab) as Transform;
       // Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());


    }

     public void OnCollisionEnter2D(Collision2D collision){

       Destroy(gameObject);
       Debug.Log("collision");
       GameData.Score ++;
       Debug.Log(GameData.Score);
   }
   
}
