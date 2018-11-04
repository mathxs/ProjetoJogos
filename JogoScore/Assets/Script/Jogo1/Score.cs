using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int PinCount = 0;
    public Text text;

	// Use this for initialization
	void Start () {

        PinCount = 0;

	}
	
	// Update is called once per frame
	void Update () {

        text.text = PinCount.ToString();

	}

}
