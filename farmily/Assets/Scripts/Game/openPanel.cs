using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public GameObject panel;
    private Button This;
    public bool opened = false;

    void Start()
    {
        panel.SetActive(false);
        This = GetComponent<Button>();
        This.onClick.AddListener(open);
    }

    void open()
    {
        Debug.Log("clicked");
        if (opened == false)
        {
            Debug.Log("opened");
            panel.SetActive(true);
            opened = true;
        }
        else if (opened == true)
        {
            Debug.Log("closed");
            panel.SetActive(false);
            opened = false;
        }
    }
}
