using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D other)
   {
       if (other.gameObject.tag=="Bullet") Destroy(other.gameObject);
       
   }
}
