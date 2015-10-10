using UnityEngine;
using System.Collections;

public class FireParticleBurst : MonoBehaviour {

    ParticleSystem loopPSystem;

	// Use this for initialization
	void Start () {
        loopPSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        loopPSystem.Play();
    }
}
