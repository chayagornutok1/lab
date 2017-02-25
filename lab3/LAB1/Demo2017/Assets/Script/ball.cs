using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour {
	public float speed;
	public Rigidbody rg;
	public TextMesh txtball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DoJump(){
		rg.velocity = new Vector3 (0, 5, 0);

	}
	int countCollosion =0;
	void OnCollisionEnter(Collision collision){
		countCollosion++;
		txtball.text = "" + countCollosion.ToString ();
	}

}

