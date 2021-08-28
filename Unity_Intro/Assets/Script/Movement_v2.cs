using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_v2 : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Hi, I am a cube");
   
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hi, I am a cube");
    }

    private void FixedUpdate()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        
        //movement
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, speed*Input.GetAxis("Vertical")*Time.deltaTime);
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }
    }
}
