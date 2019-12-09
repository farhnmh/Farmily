using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockManager : MonoBehaviour
{
    public List<GameObject> locked;
    public int totalLockLevel;
    public int openedLevel;

    void Start()
    {
        for (int i = 0; i <= totalLockLevel - 1; i++)
        {
            locked[i].SetActive(true);
        }
    }

    void Update()
    {
        openedLevel = PlayerPrefs.GetInt("Progress Level");
        for (int i = 0; i < openedLevel - 1; i++)
        {
            locked[i].SetActive(false);
        }
    }
}
