using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class resetProgression : MonoBehaviour
{
    private Button This;

    void Start()
    {
        This = GetComponent<Button>();
        This.onClick.AddListener(reset);
    }

    void reset()
    {
        PlayerPrefs.SetInt("Progress Level", 1);

        PlayerPrefs.SetInt("Gold Medal", 0);
        PlayerPrefs.SetInt("Silver Medal", 0);
        PlayerPrefs.SetInt("Bronze Medal", 0);

        PlayerPrefs.SetString("Level 1", "Level 1");
        PlayerPrefs.SetString("Level 2", "Level 2");
        PlayerPrefs.SetString("Level 3", "Level 3");
    }
}
