using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliJump : MonoBehaviour
{
    public void StartJumping()
    {
        transform.LeanMoveLocal(new Vector3(-250, 570,-47), 1f).setEaseOutQuart().setLoopPingPong();
    }
}
