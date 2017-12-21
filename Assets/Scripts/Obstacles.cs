using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

    private Camera cam;
    private Transform deletePoint;

    private void Awake()
    {
        cam = Camera.main;
        deletePoint = cam.transform.GetChild(2);
    }


    // Update is called once per frame
    void Update()
    {
       DisableGameObject();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("you lose");
        }
    }

    public void DisableGameObject()
    {
        if (transform.position.y > deletePoint.transform.position.y)
        {
            gameObject.SetActive(false);
        }
    }
}
