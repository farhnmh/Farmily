using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class investButtonLevel3 : MonoBehaviour
{
    public bool opened = false;
    public GameObject panel;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(click);
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
