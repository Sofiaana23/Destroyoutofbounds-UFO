using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    private float spawnRangeX = 150f;
    private float spawnPosZ = 195f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUFO() 
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //Picks a random UFO from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation); //Spawns index UFO from the array
    }
}
