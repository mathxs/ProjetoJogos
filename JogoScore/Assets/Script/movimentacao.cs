using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    private bool isPinned = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            col.GetComponent<rotator>().speed *= -1f;
            isPinned = true;
        }else if (col.tag == "Pin")
        {
            //End Game
            Debug.Log("End Game");
        }
    }

}
