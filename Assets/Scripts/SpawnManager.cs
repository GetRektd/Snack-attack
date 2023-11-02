using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    

    public GameObject [] spherePrefabs;

    private float spawnInterval = 1.5f;

    private float startDelay = 2;

    private float spawnRangeX = 9;

    private float spawnPosZ = 8;

    private float spawnPosY  = 13;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomBalls", startDelay, spawnInterval);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalls ()

    {
        int sphereIndex = Random.Range(0, spherePrefabs.Length);

        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ) );

        Instantiate(spherePrefabs[sphereIndex], spawnPosZ, spherePrefabs[sphereIndex].transform.rotation);

    }
}
