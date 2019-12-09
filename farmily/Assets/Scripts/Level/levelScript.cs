using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class levelScript : MonoBehaviour
{
    private GameObject level1;
    private GameObject level2;
    private GameObject level3;
    private GameObject level4;
    private GameObject level5;
    private GameObject level6;
    private GameObject level7;
    private GameObject level8;

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;

    public bool bool2 = false;
    public bool bool3 = false;
    public bool bool4 = false;
    public bool bool5 = false;
    public bool bool6 = false;
    public bool bool7 = false;
    public bool bool8 = false;

    public int level;

    // Start is called before the first frame update
    void Start()
    {
        level1 = GameObject.FindGameObjectWithTag("lock1");
        button1 = level1.GetComponent<Button>();
        button1.onClick.AddListener(levelSatu);

        level2 = GameObject.FindGameObjectWithTag("lock2");
        button2 = level2.GetComponent<Button>();
        button2.onClick.AddListener(levelDua);
        level2.SetActive(false);

        level3 = GameObject.FindGameObjectWithTag("lock3");
        button3 = level3.GetComponent<Button>();
        button3.onClick.AddListener(levelTiga);
        level3.SetActive(false);

        level4 = GameObject.FindGameObjectWithTag("lock4");
        button4 = level4.GetComponent<Button>();
        button4.onClick.AddListener(levelEmpat);
        level4.SetActive(false);

        level5 = GameObject.FindGameObjectWithTag("lock5");
        button5 = level5.GetComponent<Button>();
        button5.onClick.AddListener(levelLima);
        level5.SetActive(false);

        level6 = GameObject.FindGameObjectWithTag("lock6");
        button6 = level6.GetComponent<Button>();
        button6.onClick.AddListener(levelEnam);
        level6.SetActive(false);

        level7 = GameObject.FindGameObjectWithTag("lock7");
        button7 = level7.GetComponent<Button>();
        button7.onClick.AddListener(levelTujuh);
        level7.SetActive(false);

        level8 = GameObject.FindGameObjectWithTag("lock8");
        button8 = level8.GetComponent<Button>();
        button8.onClick.AddListener(levelDelapan);
        level8.SetActive(false);
    }

    void Update()
    {
        if (bool2 == true)
        {
            level2.SetActive(true);
        }
        else
            level2.SetActive(false);
        if (bool3 == true)
        {
            level3.SetActive(true);
        }
        else
            level3.SetActive(false);
        if (bool4 == true)
        {
            level4.SetActive(true);
        }
        else
            level4.SetActive(false);
        if (bool5 == true)
        {
            level5.SetActive(true);
        }
        else
            level5.SetActive(false);
        if (bool6 == true)
        {
            level6.SetActive(true);
        }
        else
            level6.SetActive(false);
        if (bool7 == true)
        {
            level7.SetActive(true);
        }
        else
            level7.SetActive(false);
        if (bool8 == true)
        {
            level8.SetActive(true);
        }
        else
            level8.SetActive(false);

        PlayerPrefs.SetInt("level", level);
    }

    public void levelSatu()
    {
        level = 1;
    }
    public void levelDua()
    {
        level = 2;
    }
    public void levelTiga()
    {
        level = 3;
    }
    public void levelEmpat()
    {
        level = 4;
    }
    public void levelLima()
    {
        level = 5;
    }
    public void levelEnam()
    {
        level = 6;
    }
    public void levelTujuh()
    {
        level = 7;
    }
    public void levelDelapan()
    {
        level = 8;
    }
}