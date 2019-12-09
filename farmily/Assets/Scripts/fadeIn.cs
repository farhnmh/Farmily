using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class fadeIn : MonoBehaviour
{
    private Image This;

    void Start()
    {
        This = GetComponent<Image>();

        This.canvasRenderer.SetAlpha(0.0f);
        This.CrossFadeAlpha(1, 1, false);
    }
}
