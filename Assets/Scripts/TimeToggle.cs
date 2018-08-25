using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour {
    public delegate void swapButton();
    public static event swapButton onPress;
	// Use this for initialization
	void Start () {
        onPress();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K))
        {
            if (onPress != null)
                onPress();
        }
	}
}
