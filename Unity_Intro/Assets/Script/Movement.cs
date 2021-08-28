using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
   
    
    
    void Start()
    {
        print("A moving cube");
        Debug.Log("Hello! My name is Cube");
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        // Move
        transform.Translate(speed * Input.GetAxis("Horizontal") *Time.deltaTime, 0f,speed * Input.GetAxis("Vertical") *Time.deltaTime );
        // Jump
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }
        
    }
}
