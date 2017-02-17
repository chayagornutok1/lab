using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedMove : MonoBehaviour {

    public Rigidbody rg;
    public float velocity;

	void Start () {

        rg.velocity = new Vector3(velocity, 0, 0);

	}
	
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        //Debug.LogFormat ("collision is (0)",collision.gameObject.tag);
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
        }

    }	
}
