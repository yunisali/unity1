﻿using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour
{
    public GameObject plane;
    public float speed = 3f;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
            plane.transform.Rotate(0.0f, 0.0f, -2.0f);
        }
        else
        {
            plane.transform.Rotate(0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed);
            plane.transform.Rotate(.0f, 0.0f, 2.0f);


        }
        else
        {
            plane.transform.Rotate(0.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * speed);
        }
    }
}
