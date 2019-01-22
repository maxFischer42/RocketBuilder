using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

    public float thrust;
    public ParticleSystem part;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow) && GameObject.FindObjectOfType<Cockpit>())
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * thrust);
            part.Play();
        }
        else
        {
            part.Stop();
        }
	}
}
