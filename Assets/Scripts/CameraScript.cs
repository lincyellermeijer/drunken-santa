using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject santa;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, santa.transform.position.y - 2, transform.position.z);
    }
}
