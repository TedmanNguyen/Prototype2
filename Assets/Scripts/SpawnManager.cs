using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        //Spawn animals at the start
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    //Separate method to spawn animals
    void SpawnRandomAnimal()
    {
        //Picks an animal randomly
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Cleans up Vector3 of where to spawn
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
