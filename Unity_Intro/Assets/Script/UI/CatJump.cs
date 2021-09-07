using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatJump : MonoBehaviour
{
    public void StartJumping()
    {
        transform.LeanMoveLocal(new Vector3(-520, 270), 1f).setEaseOutQuart().setLoopPingPong();
    }
}
