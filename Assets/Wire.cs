using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wire : MonoBehaviour
{
    private UnityEngine.UI.Image image;
    public void Initialize()
    {
       image = GetComponent<UnityEngine.UI.Image>();
        SetColor(Color.black);
    }

    public void SetColor(Color color)
    {
        image.color = color;
    }

}