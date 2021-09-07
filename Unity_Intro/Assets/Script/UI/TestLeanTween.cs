using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLeanTween : MonoBehaviour
{

    // Start is called before the first frame update

    void Start()
    {
        LeanTween.moveX(gameObject, 6, 3);
    }

}