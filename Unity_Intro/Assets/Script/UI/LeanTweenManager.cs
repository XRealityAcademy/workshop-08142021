using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenManager : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(Cube1, -4, 1f).setEaseInElastic().setLoopPingPong();
        LeanTween.moveY(Cube2, -2, 2f).setEaseLinear().setLoopPingPong();
        LeanTween.moveX(Cube2, -1, 1f).setEaseSpring().setLoopPingPong();
        LeanTween.moveY(Cube3, -3, 1f).setEaseShake().setLoopPingPong();
        LeanTween.rotateY(Cube4, -90, 1f).setEaseInQuint().setLoopPingPong();
        LeanTween.rotateX(Cube5, 90, 2f).setEaseInQuint().setLoopPingPong();




    }


}
