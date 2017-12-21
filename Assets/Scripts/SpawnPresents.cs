using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPresents : MonoBehaviour {

    public GameObject present;
    public int numberOfPresents;
    public float randomRange;
    public float distanceBetweenPresents;

    private bool spawned = false;

	void Update ()
    {
        if (!spawned)
        {
            Spawn();
            spawned = true;
        }   
	}

    void Spawn()
    {
        for (int i = 0; i < numberOfPresents; i++)
        {
            Vector2 randomLocation = new Vector2(Random.Range(-randomRange, randomRange), -distanceBetweenPresents);
            GameObject presentClone = Instantiate(present, new Vector2(randomLocation.x, randomLocation.y * i), Quaternion.Euler(30, 180, 0));
        }
    }
}
