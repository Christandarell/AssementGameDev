using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour

{
    public Rigidbody2D ZombieRb;
    public float speed;
    void FixedUpdate()
    {
        ZombieRb.velocity = Vector2.left * speed;
    }
    
}
