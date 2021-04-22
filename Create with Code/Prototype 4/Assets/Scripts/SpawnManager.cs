using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(false), powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(false), powerupPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition(bool drop)
    {
        Vector3 randomSpawn;
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnZ = Random.Range(-spawnRange, spawnRange);
        if (drop) {
            randomSpawn = new Vector3(spawnX, 15, spawnZ);
        }
        else
        {
            randomSpawn = new Vector3(spawnX, 0, spawnZ);
        }
        return randomSpawn;
    }

    public void SpawnEnemyWave(int numberOfEnemies)
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(true), enemyPrefab.transform.rotation);
        }
    }
}
