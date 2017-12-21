using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    //Object Poolers

    public ObjectPool obstaclePool;

    // Spawn Range

    public Transform minSpawnPos, maxSpawnPos;
    private Vector3 spawnPosition;

    //Timers
    public float obstacleSpawnInterval = 5f;
    float obstacleTimer = 0;
    

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (obstacleTimer < obstacleSpawnInterval)
        {
            obstacleTimer += Time.deltaTime;
        }
        else
        {
            obstacleTimer = 0;
            SpawnObject(obstaclePool);
           
        }

    }

    //Retrieves object from the pool and spawns it on a random y location
    void SpawnObject(ObjectPool pool)
    {
        spawnPosition = new Vector3( Random.Range(minSpawnPos.position.x, maxSpawnPos.position.x), minSpawnPos.position.y, 1);
        GameObject newItem = pool.GetPooledObject();
        newItem.transform.position = spawnPosition;
        newItem.transform.rotation = transform.rotation;
        newItem.SetActive(true);
    }
}
