using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosY = 25;

    private float startDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        // Using invoke to make the balls spawn at a different time, between 3 and 5 seconds.
        Invoke("SpawnRandomBall", startDelay);
    }
    // Update is called once per frame
    void Update()
    {

    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {

        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2,4));

    }

}
