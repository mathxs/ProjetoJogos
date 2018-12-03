using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class main : MonoBehaviour {
	
	public GameObject proximo;
	public GameObject ultimo;
    public Button button;
    public Text Text;
	public int level;
	public bool estado;

	private void newBlock()
	{
		if (ultimo != null)
		{
            proximo.transform.position = new Vector3(Mathf.Round(proximo.transform.position.x), proximo.transform.position.y, Mathf.Round(proximo.transform.position.z));
            proximo.transform.localScale = new Vector3(ultimo.transform.localScale.x - Mathf.Abs(proximo.transform.position.x - ultimo.transform.position.x), ultimo.transform.localScale.y, ultimo.transform.localScale.z - Mathf.Abs(proximo.transform.position.z - ultimo.transform.position.z));
            proximo.transform.position = Vector3.Lerp(proximo.transform.position, ultimo.transform.position, 0.5f) + (Vector3.up * 5f);
            Text.text = "Ponto: " + level;
            if (proximo.transform.localScale.x <= 0f || proximo.transform.localScale.z <= 0f)
            {
                estado = true;
                return;
            }
		}

		ultimo = proximo;
		proximo = Instantiate(ultimo);
		proximo.name = level + "";
		proximo.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.HSVToRGB((level / 100f) % 1f, 1f, 1f));
        level++;
       
        Camera.main.transform.position = proximo.transform.position + new Vector3(100,100,100);
        Camera.main.transform.LookAt(proximo.transform.position);
	}

	// Use this for initialization
	void Start () {
		newBlock();
        button.interactable = false;
        button.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(estado)
        {
            button.gameObject.SetActive(true);
            button.interactable = true;
            button.enabled = true;

            if (PlayerPrefs.GetInt("Jogo2Pontuacao", 0) < level)
            {
                PlayerPrefs.SetInt("Jogo2Pontuacao", level);
            }
            
            PlayerPrefs.SetFloat("Jogo2Metrica", (PlayerPrefs.GetFloat("Jogo2Metrica", 0) + level) / 2);

            return;
		}

		var time = Mathf.Abs(Time.realtimeSinceStartup % 2f - 1f);

		var pos1 = ultimo.transform.position + Vector3.up * 10f;
		var pos2 = pos1 + ((level % 2 == 0) ? Vector3.left : Vector3.forward) * 120;

		if (level % 2 == 0){
			proximo.transform.position = Vector3.Lerp(pos2, pos1, time);
		}
		else{
			proximo.transform.position = Vector3.Lerp(pos1, pos2, time);
		}
		if (Input.GetMouseButtonDown(0)){
			newBlock();
		}
	}

    public void Voltando()
    {
        SceneManager.LoadScene(2);
    }
}
