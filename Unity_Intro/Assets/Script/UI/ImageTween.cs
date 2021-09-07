using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTween : MonoBehaviour
{
    public Image image;

    public float tweenTime;

    public Color beginColor, endColor;
    // Start is called before the first frame update
    public void PicTween()
    {
        LeanTween.value(gameObject, 0.5f, 1, tweenTime)
            .setEasePunch()
            .setOnUpdate((value) =>
            {
                image.fillAmount = value;
               // image.color = Color.Lerp(beginColor, endColor, value);

            });
        Debug.Log("It is active");
    }
}
