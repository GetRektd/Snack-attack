using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    

    public GameObject[] spherePrefabs;

    private float spawnInterval = 1.5f;

    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomBalls", startDelay, spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalls()

    {
        int sphereIndex = Random.Range(0, spherePrefabs.Length);
        Instantiate(spherePrefabs[sphereIndex], new Vector3(Random.Range(-8, 8), 10, Random.Range(-8, 8)), spherePrefabs[sphereIndex].transform.rotation);

    }
}
