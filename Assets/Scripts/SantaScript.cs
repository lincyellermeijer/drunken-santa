using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaScript : MonoBehaviour {

    public float speed;
    public float rotateSpeed;


    void Start ()
    {
		
	}
	
	void Update ()
    {
        Move();
	}

    void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        transform.Rotate(0, 0, rotateSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotateSpeed *= -1;
        }
    }
}
