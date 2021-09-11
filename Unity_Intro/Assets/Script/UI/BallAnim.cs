using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { // (1,1,1)
        transform.LeanScale(Vector3.one, 2f).setEaseOutBounce().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
