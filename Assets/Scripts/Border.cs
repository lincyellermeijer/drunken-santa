using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("you lose");
        }
    }
}
