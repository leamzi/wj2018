using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {
    public PlayerMovement playerObj;
    public Animator playerAnim;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        switch (playerObj.status)
        {
            case 0:
                playerAnim.Play("Idle");
                Debug.Log("Playing Idle");
                break;
            case 1:
                playerAnim.Play("Moving");
                Debug.Log("Playing Moving");
                break;
            case 2:
                playerAnim.Play("Jump");
                Debug.Log("playing Jump");
                break;
        }

    }
 }
        

