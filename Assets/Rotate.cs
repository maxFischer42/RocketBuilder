using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public Vector2 bounds = new Vector2(160, -180);
    private Camera mainCam;

	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float newRot = mainCam.transform.position.y;
        newRot *= 0.1f;
        if (newRot >= -180 && newRot <= 160)
        {
            transform.rotation = Quaternion.Euler(newRot, 0f, 0f);
        }

        if(Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            mainCam.orthographicSize -= 0.1f;
        }
        else if(Input.GetAxisRaw("Mouse ScrollWheel") < 0)
        {
            mainCam.orthographicSize += 0.1f;
        }
    }
}
