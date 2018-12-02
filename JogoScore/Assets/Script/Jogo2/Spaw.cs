﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaw : MonoBehaviour {
	
	public float spawnObjetos =1f;

	public GameObject forma;

	private float nextSpawn;
	// Update is called once per frame
	void Update () {

		if(Time.time >= nextSpawn)
		{
			Instantiate(forma, Vector3.zero, Quaternion.identity);
			nextSpawn = Time.time + 1f;
		}
		
	}
}
