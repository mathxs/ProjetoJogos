using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spaw : MonoBehaviour {
	
	public float spawnObjetos = 1f;
    public int level = 1;
    public Text Text;
    public GameObject forma;
    public float velocidade = 30f;
    float movement = 0f;
    public Button button;
    private float nextSpawn = 0f;
    public bool situacao;

    void Start()
    {
        button.interactable = false;
        button.enabled = false;
        situacao = false;
    }

    // Update is called once per frame
    void Update () {

        if (situacao)
        {
            button.gameObject.SetActive(true);
            button.interactable = true;
            button.enabled = true;
            return;
        }

        movement = Input.GetAxisRaw("Horizontal");

        if (Time.time >= nextSpawn)
		{

            Instantiate(forma, Vector3.zero, Quaternion.identity);
			nextSpawn = Time.time + level / spawnObjetos;
            level++;
            Text.text = "Ponto: " + level;
        }
		
	}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -velocidade);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        situacao = true;
        
    }
}
