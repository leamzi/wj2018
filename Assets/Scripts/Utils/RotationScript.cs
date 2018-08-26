using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotation();

    }

    void Rotation()
    {
        transform.Rotate(Vector3.forward * -90 * Time.deltaTime);
    }
}
