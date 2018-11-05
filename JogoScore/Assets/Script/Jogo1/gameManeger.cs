﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameManeger : MonoBehaviour {

    private bool gameHasEnded = false;
    public rotator rotator;
    public spawer spaw;
    public Button button;
    public Vector2 bola1;
    public Vector2 bola2;
    public Animator animator;
    public GameObject[] bolas;
    public List<float> angulos;

    // Use this for initialization
    void Start () {

        button.interactable = false;
        button.enabled = false;
        rotator.enabled = true;
        spaw.enabled = true;

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
        gameHasEnded = true;
        button.gameObject.SetActive(true);
        button.interactable = true;
        button.enabled = true;
        if (PlayerPrefs.GetInt("Pontuacao", 0) < Score.PinCount)
        {
            PlayerPrefs.SetInt("Pontuacao", Score.PinCount);
        }

        // Conta a Metrica de Simetria
                     
        //List<float> angulos;

        float anguloideal;

        bolas = GameObject.FindGameObjectsWithTag("Pin");
        int bolasCount = bolas.Length;
        
        angulos = new List<float>();
        //angulos.Add(bolasCount);    

        anguloideal = 360 / bolasCount;

        for (int i = 0; i < bolasCount -1 ; i++)
        {
            bola1 = bolas[i].transform.position - rotator.transform.position;
            Debug.Log(bola1);
            bola2 = bolas[i + 1].transform.position - rotator.transform.position;
            Debug.Log(bola2);
            angulos.Add(Vector2.Angle(bola1, bola2));
            Debug.Log(angulos[i]);
        }
        
        //Final da Metrica de Simetria

        animator.SetTrigger("EndGame");
        Debug.Log("End Game");
    }

    public void Voltando()
    {
        SceneManager.LoadScene(2);
    }


}
