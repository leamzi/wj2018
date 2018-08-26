using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
    public AudioSource jump;
    public AudioSource checkpoint;
    public AudioSource die;
    public AudioSource collectible;
	void Awake()	{
//		Debug.Log ("Music player Awake" + GetInstanceID ());
		if (instance != null)	{
			Destroy (gameObject);
//			print ("duplicate music player self-destructing");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
//		Debug.Log ("Music player Start" + GetInstanceID ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayJump()
    {
        jump.Play();
    }

     public void PlayCheckpoint()
    {
        checkpoint.Play();
    }

    public void PlayDie()
    {
        die.Play();
    }

    public void PlayCollectible()
    {
        collectible.Play();
    }
}
