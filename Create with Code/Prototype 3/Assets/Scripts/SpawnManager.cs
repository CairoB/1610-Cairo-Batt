using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private bool spawnReady = true;
    private float repeatMin = 0.5f;
    private float repeatMax = 2.5f;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnReady && playerControllerScript.gameOver == false) {
            spawnReady = false;
            Invoke("SpawnObstacle", Random.Range(repeatMin, repeatMax));
        }
    }

    void SpawnObstacle() {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        spawnReady = true;
    }
}
