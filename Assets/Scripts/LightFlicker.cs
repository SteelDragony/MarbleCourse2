using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

    public float flickerDelay = 0.5f;
    public float minIntensity = 0f;
    public float maxIntensity = 3f;

    float prevFlicker = 0f;
    Light flickerLight;

    bool flickeringActive = true;

	// Use this for initialization
	void Start () {
        flickerLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Toggle Flickering Light"))
        {
            flickeringActive = !flickeringActive;
        }
	    if(flickerLight != null && flickeringActive && Time.time > prevFlicker + flickerDelay)
        {
            flickerLight.intensity = Random.Range(minIntensity, maxIntensity);
            prevFlicker = Time.time;
        }
	}
}
