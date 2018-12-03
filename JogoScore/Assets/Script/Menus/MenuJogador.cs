using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuJogador : MonoBehaviour
{

    public Text pont1;
    public Text pont2;
    public Text pont3;
    public Text pont4;

    public Text metr1;
    public Text metr2;
    public Text metr3;
    public Text metr4;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        pont1.text = PlayerPrefs.GetInt("Jogo1Pontuacao", 0).ToString();
        pont2.text = PlayerPrefs.GetInt("Jogo2Pontuacao", 0).ToString();
        pont3.text = PlayerPrefs.GetInt("Jogo3Pontuacao", 0).ToString();
        pont4.text = PlayerPrefs.GetInt("Jogo4Pontuacao", 0).ToString();

        metr1.text = PlayerPrefs.GetFloat("Jogo1Metrica", 0).ToString();
        metr2.text = PlayerPrefs.GetFloat("Jogo2Metrica", 0).ToString();
        metr3.text = PlayerPrefs.GetFloat("Jogo3Metrica", 0).ToString();
        metr4.text = PlayerPrefs.GetFloat("Jogo4Metrica", 0).ToString();

    }

    public void VoltandoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
