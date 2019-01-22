using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

    public bool placed = false;
    public bool collide = false;
    bool canPlace = false;
    public float moveSpeed = 1;
    public float delayTime = 25;
    public bool isScaffolding;
    public GameObject damage;

    private void Start()
    {
        for(int i = 0; i < delayTime; i++)
        {
            if(i == delayTime - 1)
            {
                canPlace = true;
            }
        }
    }



	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            placed = true;
            if(!isScaffolding)
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        if (!placed)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(pos.x, pos.y, 0f);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Object" && !collide && collision.gameObject.GetComponent<FixedJoint2D>().connectedBody != GetComponent<Rigidbody2D>() && !isScaffolding)
        {
            collide = true;
            GetComponent<FixedJoint2D>().connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            GetComponent<FixedJoint2D>().enabled = true;

        }
        else if(collision.gameObject.tag == "Ground")
        {
            Instantiate(damage, transform);
        }
    }
}
