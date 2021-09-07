using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITween : MonoBehaviour
{
    public float tweenTime;

    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
       // TweenText();        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TweenText()
    {
        
        LeanTween.cancel(gameObject);
        transform.localScale = Vector3.one;
        LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();
        LeanTween.value(gameObject, 0.1f, 1, tweenTime).setEasePunch().setOnUpdate(setText);
    }

    public void setText(float value)
    {
        textMesh.text = value.ToString("F2");
    }
}
