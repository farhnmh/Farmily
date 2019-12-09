using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class loadingScript : MonoBehaviour
{
    public bool done = false;
    public string sceneName;

    private int level;

    public Image loadingImage;
    public Image blink;
    public GameObject levelNum;

    void Start()
    {
        blink.canvasRenderer.SetAlpha(0.0f);
        loadingImage.fillAmount = 0.0f;
        Invoke("loading", 2);
        levelNum = GameObject.FindGameObjectWithTag("LevelManager");
        level = levelNum.GetComponent<levelManager>().levelSelect;
    }

    void Update()
    {
        if (done == true && loadingImage.fillAmount <= 1.0f) {
            loadingImage.fillAmount += 0.5f * Time.deltaTime;
        }
        if (loadingImage.fillAmount >= 0.8f)
        {
            blink.CrossFadeAlpha(1, 1, false);
            Invoke("move", 3f);
        }
    }

    void loading()
    {
        loadingImage.fillAmount += 0.5f * Time.deltaTime;
        done = true;
    }

    void move()
    {
        SceneManager.LoadScene(5 + level);
    }
}