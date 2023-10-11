using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float spawnInterval = 3.0f; 
    private float nextSpawnTime = 0.0f;
    private Transform playerTransform;


    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    public float spawnDistance = 1000f;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = playerTransform.position + playerTransform.forward + new Vector3(randomX, 0, spawnDistance);

            SpawnEnemy(spawnPosition);
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnEnemy(Vector3 spawnPosition)
    {
        
        Instantiate(enemyPrefab[Random.Range(0,4)], spawnPosition, Quaternion.identity);
    }
}
