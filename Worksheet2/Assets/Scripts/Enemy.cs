using UnityEngine;
using System.Collections;
public class Enemy 
{
public int hitpoints, damage;
string name;
 
public bool enemydead;


public Enemy(int hp, int dmg, string ID, bool hasdied)
{ //this constructor assigns hitpoints, damage, and name to
 //the values passed into the constructor
hitpoints = hp;
damage = dmg;
name = ID;
enemydead = hasdied;
 }



 public void TakeDamage()
 {
 if (hitpoints>0) 
    {
    hitpoints--; //reduce HP by 1
    Debug.Log(name + "'s HP: " + hitpoints); //print out new hp
    }
 }

 
 public void Die()
 {
 enemydead=true;
 Debug.Log(name + " Has Died"); //print to the console
 }



}