using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnpos, obstaclePrefab.transform.rotation);
    }
}
