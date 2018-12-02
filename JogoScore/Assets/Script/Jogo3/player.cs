using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public float velocidade = 30f;
    float movement = 0f;
    public Button button;

    // Update is called once per frame
    void Update () {
        movement = Input.GetAxisRaw("Horizontal");
        
	}

    // Use this for initialization
    void Start()
    {
        button.interactable = false;
        button.enabled = false;

    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -velocidade);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        button.gameObject.SetActive(true);
        button.interactable = true;
        button.enabled = true;
    }

}
