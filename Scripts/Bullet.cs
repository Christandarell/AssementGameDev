using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D BulletRb;
    public float speed = 2.5f;
    public float range = 1;
    private float timer;
    public int damage = 10;
    public float knockbackForce = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       BulletRb.velocity = Vector2.right * speed;   
       timer -= Time.deltaTime;
       if(timer <0)
       {
        Destroy(gameObject);
       }
    }
    private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.GetComponent<EnemyHealth>() )
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
        collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        Destroy(gameObject);
    }
   }
   
}
