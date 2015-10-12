using UnityEngine;
using System.Collections;

public class MarbleCleanup : MonoBehaviour {

    public float cleanupHeight = -500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < cleanupHeight)
            Destroy(gameObject);
	}
}
