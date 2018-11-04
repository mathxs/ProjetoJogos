using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManeger : MonoBehaviour {

    private bool gameHasEnded = false;
    public rotator rotator;
    public spawer spaw;

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spaw.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("End Game");
    }

}
