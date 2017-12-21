using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject santa;
    public float camSpeed;
    Vector3 camPos;

	void Start ()
    {
        camPos = transform.position;
    }
	
	void Update ()
    {
        MoveCamera();
	}

    void MoveCamera()
    {
        transform.Translate(Vector2.down * camSpeed * Time.deltaTime);
    }
}
