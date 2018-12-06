using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

    public Slider slider;

	// Use this for initialization
	void Start () {

        slider.minValue = 0;
        slider.maxValue = 10;
        slider.value = PlayerPrefs.GetFloat("Volume", 5);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AlterandoVolume(float a)
    {
        PlayerPrefs.SetFloat("Volume", a);

    }
}
