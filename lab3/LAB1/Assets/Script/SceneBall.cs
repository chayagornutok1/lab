using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBall : MonoBehaviour
{
    public Text txtScore;
	public GameObject obtaclePrefab;
    // Use this for initialization
    void Start()
    {
		DoTestobtacle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    int score = 0;
    int attack = 10;
    public void DoPushButton()
    {
        score++;
        attack++;
        txtScore.text = "Score :" + score.ToString();
    }

    public void DochangeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void DochangeScenestart()
    {
        SceneManager.LoadScene(1);
    }
	public void DoTestobtacle(){
		StartCoroutine (Gameprocess ());
	}

	IEnumerator Gameprocess(){
		for (int i = 0; i < 10; i++) 
		{
			Instantiate (obtaclePrefab);
			yield return new WaitForSeconds (2);
		}
	}
}
