using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    public SantaScript santa;
    public GameObject house;
    public int scoreNeeded;
    public Transform minSpawnPos;

    private bool _spawned;
    private Vector3 spawnPosition;


    private void Awake()
    {
        _spawned = false;
        
    }
    // lazy code.
    void Update ()
    {
        if (santa.score == scoreNeeded && !_spawned)
        {
            _spawned = true;
            spawnPosition = new Vector3(transform.position.x - 3f, minSpawnPos.position.y - 10f, transform.position.z);
            GameObject _house = Instantiate(house);
            house.transform.position = spawnPosition;
            
        }
	}
}
