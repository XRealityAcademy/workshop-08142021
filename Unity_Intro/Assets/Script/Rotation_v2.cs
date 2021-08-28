using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_v2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 200f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}
