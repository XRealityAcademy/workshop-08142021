using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;

    public Rigidbody rb;

    public float jumpSpeed;


    // Update is called once per frame
    void Update()
    {
        // press A & D or Left, Right Keys
        float x = Input.GetAxis("Horizontal")* speed;
        // value between -1 to 1
        Debug.Log(x);
        // press W & S or Up, Down Keys
        float z = Input.GetAxis("Vertical")* speed;
        // movement speed
        rb.velocity = new Vector3(x, rb.velocity.y, z);

        Vector3 vel = rb.velocity;
        vel.y = 0f;
        // let the cube facing the moving direction

        if (x != 0 || z != 0)
        {
            transform.forward = vel;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }


    }
}
