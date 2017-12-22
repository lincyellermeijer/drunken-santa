using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Santa")
        {
            Debug.Log("you lose");
        }
    }
}
