using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoCores : MonoBehaviour {

	public Color[] arraycores;
	public string[] arraypalavras;
	public int[] numeros;
	public int palavraaleatoria;
    public Text PalavraSorteada;
		public bool onetime;

    // Use this for initialization
    void Start () {

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
        arraypalavras[0] = "Branco";//"Laranja";
		arraypalavras[1] = "Azul";
		arraypalavras[2] = "Verde";
		arraypalavras[3] = "Amarelo";
		arraypalavras[4] = "Vermelho";
        arraypalavras[5] = "Cinza";//"Roxo";

		numeros = new int[20];
		criasequencia();
		//jogodecores();
		var onetime = false;
	}

	// Update is called once per frame
	void Update () {
			if (!onetime)	 {
		 		jogodecores();
		 		onetime = true;
	 		}
	}

	void criasequencia(){
		//srand((unsigned) time(&t));

        for (int i = 0 ; i < 5 ; i++ ) {
		 numeros[i] = (int)(Random.Range(0,5));
	 }
 }

	void jogodecores(){


//<<<<<<< HEAD
		//for( int j = 0 ; j < 19 ; j++ ) {
		//	palavraaleatoria = (int)(Random.Range(0,5));
			//PalavraSorteada = Instantiate(GameObject);
			//PalavraSorteada.GetComponent<Text>.Text = arraypalavras[palavraaleatoria];
			//PalavraSorteada.GetComponent<Text>.Color = arraycores[numeros[j]];
			//StartCoroutine(espera());

		//}

//=======
        for (int j = 0; j < 19; j++)
        {
            palavraaleatoria = (int)(Random.Range(0, 5));
            Debug.Log(arraypalavras[palavraaleatoria]);
            PalavraSorteada.text = arraypalavras[palavraaleatoria];
            PalavraSorteada.color = arraycores[numeros[j]];
            //PalavraSorteada.GetComponent<Text>.Text = arraypalavras[palavraaleatoria];
            //PalavraSorteada.GetComponent<Text>.Color = arraycores[numeros[j]];
            //System.Threading.Thread.Sleep(10);
            StartCoroutine(espera());
//>>>>>>> 6958a3f477490d8df483187909985c4877a4c4c9

        }

	}

	IEnumerator espera(){

		 yield return new WaitForSecondsRealtime(3);

	}

    public void salvando()
    {
        /*
        if (PlayerPrefs.GetInt("Jogo4Pontuacao", 0) < level)
        {
            PlayerPrefs.SetInt("Jogo4Pontuacao", level);
        }

        PlayerPrefs.SetFloat("Jogo4Metrica", (PlayerPrefs.GetFloat("Jogo4Metrica", 0) + level) / 2);
        */

    }


}
