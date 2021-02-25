using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2.0f;
    private float timeInterval = 1.5f;
    int xRange = 20;
    int zPosition = 20;

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, timeInterval);
    }

    // Update is called once per frame
    void Update()
    {

        // we are going to use the S key to spawn animals
        if (Input.GetKeyDown(KeyCode.S))
        {

        }

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 SpawnLocation = new Vector3(Random.Range(-xRange, xRange), 0, zPosition);
        Instantiate(animalPrefabs[animalIndex], SpawnLocation, animalPrefabs[animalIndex].transform.rotation);

    }


}
