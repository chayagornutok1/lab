﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public Rigidbody rg;
    public float speed;
	public TextMesh txtBall;
	public GameObject dieEffectPrefab;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Dojump()
    {
        rg.velocity = new Vector3(0, 5, 0);
    }

    int countCollosion;
    void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("collision is (0)", collision.gameObject.tag);

        countCollosion++;
        txtBall.text = "" + countCollosion.ToString();
    }
	void OnDestroy(){
		GameObject dieEffect = Instantiate (dieEffectPrefab);
		dieEffect.transform.position = this.gameObject.transform.position;
	}

    	
}
