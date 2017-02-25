using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneball : MonoBehaviour {
	public Text txtScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int Score = 0;

	public void DoPushButton(){
		Score++;
		txtScore.text = "Score : " + Score.ToString ();
	}

	public void DoChangScene(){
	
		SceneManager.LoadScene (1);
	}
	public void Startscene(){
		SceneManager.LoadScene (0);
	}
}
