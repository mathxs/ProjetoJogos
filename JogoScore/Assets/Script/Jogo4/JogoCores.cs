﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JogoCores : MonoBehaviour {

	public Color[] arraycores;
	public string[] arraypalavras;
	public int[] numeros;
	public int palavraaleatoria;
    public Text PalavraSorteada;
	public int check;
    public int level;
    public int contador;
    private int tentativas;

    // Use this for initialization
    void Start () {

        tentativas = 0;
        level = 0;

        //Inicializa vetor de cores
        arraycores = new Color[6];
        arraycores[0] = Color.white;
		arraycores[1] = Color.blue;
		arraycores[2] = Color.green;
		arraycores[3] = Color.yellow;
		arraycores[4] = Color.red;
        arraycores[5] = Color.gray;

		//Inicializa Vetor de Palavras
		arraypalavras = new string[6];
        arraypalavras[2] = "Branco";//"Laranja";
		arraypalavras[0] = "Azul";
		arraypalavras[5] = "Verde";
		arraypalavras[4] = "Amarelo";
		arraypalavras[3] = "Vermelho";
        arraypalavras[1] = "Cinza";//"Roxo";

		numeros = new int[20];
		criasequencia();


        InvokeRepeating("LaunchProjectile", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void LaunchProjectile()
    {
        if (contador < 20 && tentativas <20)
        {
            jogodecores();
            contador++;
        }
        else
        {
            salvando();
            SceneManager.LoadScene(2);
        }
	}

	void criasequencia(){
		//srand((unsigned) time(&t));

        for (int i = 0 ; i < 5 ; i++ ) {
		 numeros[i] = (int)(Random.Range(0,5));
	 }
 }

	void jogodecores(){

        palavraaleatoria = (int)(Random.Range(0, 5));
        //Debug.Log(arraypalavras[palavraaleatoria]);
        PalavraSorteada.text = arraypalavras[palavraaleatoria];
        PalavraSorteada.color = arraycores[numeros[palavraaleatoria]];
        check = palavraaleatoria;

    }

	IEnumerator espera(){

		 yield return new WaitForSecondsRealtime(30000);

	}

    public void salvando()
    {
        if (PlayerPrefs.GetInt("Jogo4Pontuacao", 0) < level)
        {
            PlayerPrefs.SetInt("Jogo4Pontuacao", level);
        }

        PlayerPrefs.SetFloat("Jogo4Metrica", (PlayerPrefs.GetFloat("Jogo4Metrica", 0) + level) / 2);

    }

    public void bot_verm()
    {
        if(check == 3)
        {
            level++;
        }
        tentativas++;
        Debug.Log("Vermelho");

    }

    public void bot_branco()
    {
        if (check == 2)
        {
            level++;
        }
        Debug.Log("Branco");
        tentativas++;
    }

    public void bot_azul()
    {
        if (check == 0)
        {
            level++;
        }
        Debug.Log("Azul");
        tentativas++;

    }

    public void bot_verde()
    {
        if (check == 5)
        {
            level++;
        }
        Debug.Log("Verde");
        tentativas++;

    }

    public void bot_amarelo()
    {
        if (check == 4)
        {
            level++;
        }
        Debug.Log("Amarelo");
        tentativas++;


    }

    public void bot_cinza()
    {
        if (check == 1)
        {
            level++;
        }
        Debug.Log("Cinza");
        tentativas++;


    }



}
