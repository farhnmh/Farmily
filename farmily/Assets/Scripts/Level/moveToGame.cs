using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class moveToGame : MonoBehaviour
{
    private Button ini;
    public string sceneName;
    private GameObject levelNum;
    public int numButton;

    // Start is called before the first frame update
    void Start()
    {
        ini = GetComponent<Button>();
        ini.onClick.AddListener(move);
        levelNum = GameObject.FindGameObjectWithTag("LevelManager");
    }

    public void move()
    {
        levelNum.GetComponent<levelManager>().levelSelect = numButton;
        SceneManager.LoadScene(5);
    }
}
