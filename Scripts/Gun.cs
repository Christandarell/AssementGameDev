using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float coolDown = 2.5f;
    public float timer;
    void Start()
    {
        timer = coolDown; 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
       Instantiate(BulletPrefab, transform.position, Quaternion.identity);
       timer = coolDown;
        }
        
    }
    
}
