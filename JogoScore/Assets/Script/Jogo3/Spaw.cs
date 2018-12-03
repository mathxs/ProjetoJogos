using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spaw : MonoBehaviour
{

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
    void Update()
    {

        if (situacao)
        {
            button.gameObject.SetActive(true);
            button.interactable = true;
            button.enabled = true;
            new WaitForSeconds(3);

            if (PlayerPrefs.GetInt("Jogo3Pontuacao", 0) < level)
            {
                PlayerPrefs.SetInt("Jogo3Pontuacao", level);
            }

            PlayerPrefs.SetFloat("Jogo3Metrica", (PlayerPrefs.GetFloat("Jogo3Metrica", 0) + level) / 2);

            new WaitForSeconds(3);
            SceneManager.LoadScene(2);
            return;
        }

        movement = Input.GetAxisRaw("Horizontal")/3;

        if (Time.time >= nextSpawn)
        {
            forma.GetComponent<LineRenderer>().SetColors(Color.HSVToRGB(1f, (level / 100f) % 1f, 1f), Color.HSVToRGB((level / 100f) % 1f, 1f, 1f));
            //forma.GetComponent<LineRenderer>().material.SetColor("_Color", Color.HSVToRGB(1f, (level / 100f) % 1f, 1f));
            Instantiate(forma, Vector3.zero, Quaternion.identity);
            nextSpawn = Time.time + 1/level + 2;
            level++;

            if (PlayerPrefs.GetInt("Jogo3Pontuacao", 0) < level)
            {
                PlayerPrefs.SetInt("Jogo3Pontuacao", level);
            }

            Text.text = "Ponto: " + (level-1);
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
 