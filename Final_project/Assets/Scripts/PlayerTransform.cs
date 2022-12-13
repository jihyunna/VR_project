﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public float speed = 30f;
    public float scrollSpeed = 2000.0f;
    Vector3 fb = new Vector3(0, 0, 1);
    Vector3 lr = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * Time.deltaTime;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(fb * v * speed);
        transform.Rotate(lr * h * speed);

        float scroollWheel = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView -= scroollWheel * Time.deltaTime * scrollSpeed;
    }

}
