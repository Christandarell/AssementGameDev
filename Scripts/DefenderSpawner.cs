using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gunner;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnGunner()
    {
        Instantiate(gunner, spawnPoint.position, Quaternion.identity);
    }
}
