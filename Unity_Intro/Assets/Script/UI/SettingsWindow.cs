using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SettingsWindow : MonoBehaviour
{

    public void Start()
    {
        transform.localScale = Vector3.zero;
    }
    public void Open()
    {
        transform.LeanScale(Vector3.one, 0.8f);
    }

    public void Close()
    {
        transform.LeanScale(Vector3.zero, 1f).setEaseInBack();
    }
}
