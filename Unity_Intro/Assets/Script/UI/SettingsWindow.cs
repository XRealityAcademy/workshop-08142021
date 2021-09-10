using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SettingsWindow : MonoBehaviour
{

    public void Start()
    {
        transform.localScale = Vector2.zero;
    }
    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.8f);
    }

    public void Close()
    {
        transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
}
