using UnityEngine;
using System.Collections;

public class Whirlwind : MonoBehaviour {

    public float power = 10f;
    public float upPower = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if(rb != null)
        {
            Vector3 toCenter = transform.position - other.gameObject.transform.position;
            toCenter.y = upPower;
            rb.AddForce(toCenter * power);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        TrailRenderer trial = other.gameObject.GetComponent<TrailRenderer>();
        if(trial != null)
        {
            trial.enabled = true;
        }
    }
}
