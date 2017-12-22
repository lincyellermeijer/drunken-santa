using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float scrollSpeed;

    Material _mat;

    private void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        _mat.mainTextureOffset = new Vector2(0f, Camera.main.transform.position.y * scrollSpeed);
    }
}
