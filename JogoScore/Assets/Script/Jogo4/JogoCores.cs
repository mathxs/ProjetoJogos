using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoCores : MonoBehaviour {

	public Color[] arraycores;
	public string[] arraypalavras;
	public int[] numeros;
	public string palavraaleatoria;



	// Use this for initialization
	void Start () {

		//Inicializa vetor de cores
		arraycores = new Color[6];
		arraycores[0] = Color.orange;
		arraycores[1] = Color.blue;
		arraycores[2] = Color.green;
		arraycores[3] = Color.yellow;
		arraycores[4] = Color.red;
		arraycores[5] = Color.purple;

		//Inicializa Vetor de Palavras
		arraypalavras = new string[6];
		arraypalavras[0] = "Laranja";
		arraypalavras[1] = "Azul";
		arraypalavras[2] = "Verde";
		arraypalavras[3] = "Amarelo";
		arraypalavras[4] = "Vermelho";
		arraypalavras[5] = "Roxo";

		numeros[] = new int[20];
		criasequencia();
		jogodecores();

	}

	// Update is called once per frame
	void Update () {


	}

	void criasequencia(){
		srand((unsigned) time(&t));

		for( i = 0 ; i < 19 ; i++ ) {
		 numeros[i] = (int)(rand() % 5);
	 }
 }

	void jogodecores(){


		for( i = 0 ; i < 19 ; i++ ) {
			palavraaleatoria = (int)(rand() % 5);
			PalavraSorteada.GetComponent<Text>.Text = arraypalavras[palavraaleatoria];
			PalavraSorteada.GetComponent<Text>.Color = arraycores[numeros[j]];
			StartCoroutine(espera());

		}



	}

	IEnumerator espera(){

		 yield return new WaitForSeconds(5);

	}


}
