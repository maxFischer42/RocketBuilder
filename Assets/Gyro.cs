using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().AddForce((-1 * GetComponent<Rigidbody2D>().velocity) / 10);
	}
}
