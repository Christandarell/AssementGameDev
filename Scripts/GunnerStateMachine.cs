using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerStateMachine : MonoBehaviour
{
    public GunnerState gunnerState;
    public float detectionRange = 6;
    public LayerMask enemyLayer;
    public DefenderMovement defenderMovement;
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    { 
        gunnerState = GunnerState.Walking;
        gun.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gunnerState == GunnerState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, detectionRange, enemyLayer);
            if(hit.collider == null)
            {
                gunnerState = GunnerState.Shooting;
                gun.enabled = true;
                defenderMovement.enabled = false;
                
            }
        }
    }
    public enum GunnerState
    {
        idle,
        Walking,
        Shooting
    };
}
