using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;
    // Use this for initialization

    void Spawn()
    {
        Vector3 rand = Random.onUnitSphere * spawnRadius;
        rand.z = 0;
        Vector3 position = transform.position + rand;
        int randomIndex = Random.Range(0, asteroidPrefabs.Length);
        GameObject clone = Instantiate(asteroidPrefabs[randomIndex]);
        clone.transform.position = position;
    }
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
