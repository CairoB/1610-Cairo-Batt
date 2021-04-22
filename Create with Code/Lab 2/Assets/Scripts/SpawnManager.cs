using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    public float zEnemySpawn = 20.0f;
    public float yEnemySpawn = 0.5f;
    public int xSpawnRange = 16;
    public float startDelay = 1.0f;
    public float enemySpawnTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomX = Random.Range(-xSpawnRange, xSpawnRange);
            int randomIndex = Random.Range(0, enemies.Length);
            if (randomIndex == 0)
            {
                Vector3 spawnPos = new Vector3(randomX, yEnemySpawn + 1.0f, zEnemySpawn);
                Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
            }
            else if (randomIndex == 1)
            {
                Vector3 spawnPos = new Vector3(randomX, yEnemySpawn, zEnemySpawn + 1.0f);
                Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
            }
            else
            {
                Vector3 spawnPos = new Vector3(randomX, yEnemySpawn, zEnemySpawn);
                Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
            }
        }
    }
}
