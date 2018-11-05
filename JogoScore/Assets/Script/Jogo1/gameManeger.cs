using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManeger : MonoBehaviour {

    private bool gameHasEnded = false;
    public rotator rotator;
    public spawer spaw;
    public Button button;

    public Animator animator;

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

        Vector2 bola2;
        Vector2 bola2;
        using System.Collections.Generics;
        public List<float> angulos;

        var bolas = GameObject.FindGameObjectsWithTag("pin");
        var bolasCount = bolas.Length;
        angulos = new List<float>();
        angulos.Add(bolasCount);    

        for (var i = 0 to bolasCount)
        {
            bola1 =  bolas[i].transform.position - rotator.transform.position   
            bola2 = bolas[i+1].transform.position - rotator.transform.position
            angulo = 
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
