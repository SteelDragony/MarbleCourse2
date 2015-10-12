using UnityEngine;
using System.Collections;

public class ToggleCamera : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Toggle Camera"))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
	}
}
