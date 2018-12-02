using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forma : MonoBehaviour {

    public Rigidbody2D rb;
	public float speed = 3f;

	// Use this for initialization
	void Start () {
		rb.rotation = Random.Range(0f , 360f);
		transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
