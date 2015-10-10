using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MarbleSpawner : MonoBehaviour {

    public List<GameObject> spawnableMarbles = new List<GameObject>();
    public float spawnDelay = 1f;

    float prevSpawn = 0f;
    bool spawnActive = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Toggle Spawn"))
            spawnActive = !spawnActive;

        if (Time.time > prevSpawn + spawnDelay && spawnActive)
        {
            Instantiate(spawnableMarbles[Random.Range(0, spawnableMarbles.Count)], transform.position, Quaternion.identity);
            prevSpawn = Time.time;
        }
	}
}
