using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;// Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(Cube1, -3, 2).setEaseOutBounce().setLoopPingPong();;
        LeanTween.moveY(Cube2, -3, 2).setEaseInOutBack().setLoopPingPong();;
        LeanTween.moveY(Cube3, -3, 2).setEaseInCirc().setLoopPingPong();;
        LeanTween.moveX(Cube4, -3, 0.5f).setEaseLinear().setLoopPingPong();
        LeanTween.moveY(Cube4, -3, 1).setEaseInOutSine().setLoopPingPong();;
        LeanTween.rotateY(Cube5, 90, 2).setEaseInOutSine().setLoopClamp();;  
        LeanTween.moveY(Cube5, -3, 1).setEaseInOutSine().setLoopPingPong();;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
