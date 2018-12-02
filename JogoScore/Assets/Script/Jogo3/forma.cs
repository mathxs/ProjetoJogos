using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forma : MonoBehaviour {

    public Rigidbody2D rb;
	public float speed = 0.02f;

	// Use this for initialization
	void Start () {
		rb.rotation = Random.Range(0f , 360f);
		transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () { 
        transform.localScale -= Vector3.one * speed * Time.deltaTime;
        if (transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
