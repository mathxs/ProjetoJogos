using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<AudioSource>().volume = (PlayerPrefs.GetFloat("Volume", 5));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {

        GetComponent<AudioSource>().volume = (PlayerPrefs.GetFloat("Volume", 5));
        GetComponent<AudioSource>().Play();

    }

}
