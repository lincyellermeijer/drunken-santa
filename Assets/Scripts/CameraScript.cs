using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject santa;
    public float camSpeed;
    public float maxY;

    private void Start()
    {
        cam = GetComponent<Camera>();    
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
