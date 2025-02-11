using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
   public int damage = 25;
   private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.GetComponent<TreeHealth>() )
    {
        collision.gameObject.GetComponent<TreeHealth>().health -= damage;
        Destroy(gameObject);
    }
    if(collision.gameObject.GetComponent<DefenderHealth>() )
    {
         collision.gameObject.GetComponent<DefenderHealth>().health -= damage;
        Destroy(gameObject);
    }
   }
  
}
