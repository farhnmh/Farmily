using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class controllerScript : MonoBehaviour
{
    public int choice;
    public GameObject arrowCont;
    
    public Button tilt;
    public Button arrow;

    void Start()
    {
        tilt.onClick.AddListener(tiltChosen);
        arrow.onClick.AddListener(arrowChosen);
    }

    void Update()
    {
        choice = PlayerPrefs.GetInt("controller");
        
        if (choice == 0)
        {
            arrowCont.SetActive(false);
        }
        else if (choice == 1)
        {
            arrowCont.SetActive(true);
        }
    }

    void tiltChosen()
    {
        PlayerPrefs.SetInt("controller", 0);
    }

    void arrowChosen()
    {
        PlayerPrefs.SetInt("controller", 1);
    }
}
