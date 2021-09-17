using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliJump : MonoBehaviour
{
   
    public void Jump()
    {
        LeanTween.moveY( gameObject,570, 1f).setEaseOutQuart();
        
    }
    

    public void Back()
    {
        LeanTween.color(gameObject, Color.magenta, 2f);
    }
}
