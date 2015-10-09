using UnityEngine;
using System.Collections;

public class MarbleSpawner : MonoBehaviour {

    public GameObject marble;
    float prevSpawn = 0f;
    public float spawnDelay = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > prevSpawn + spawnDelay)
        {
            Instantiate(marble, transform.position, Quaternion.identity);
            prevSpawn = Time.time;
        }
	}
}
