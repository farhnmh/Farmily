using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class clickSetting : MonoBehaviour
{
    public bool opened = false;
    public GameObject panel;
    private Button This;

    void Start()
    {
        This = GetComponent<Button>();
        This.onClick.AddListener(click);
    }

    void click()
    {
        if (opened == true)
        {
            panel.SetActive(false);
            opened = false;
        }
        else if (opened == false)
        {
            panel.SetActive(true);
            opened = true;
        }
    }
}
