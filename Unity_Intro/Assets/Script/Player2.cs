using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player2 : MonoBehaviour
{
    public float speed;

    public Rigidbody rb;

    public float jumpSpeed; 
    
    
    // Update is called once per frame
    void Update()
    {
       // press A & D or Left, Right keys
        float x = Input.GetAxis("Horizontal") * speed;
        // Value between -1 to 1
        Debug.Log(x);
        // press W & S or Up, Down keys
        float z = Input.GetAxis("Vertical") * speed;
        // Value between -1 to 1        
        Debug.Log(z);

        rb.velocity = new Vector3(x, rb.velocity.y, z);

        Vector3 vel = rb.velocity;
        vel.y = 0f;

        if (x!= 0 || z!= 0)
        {
            transform.forward = vel;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpSpeed, ForceMode.Impulse);
        }



    }
}
