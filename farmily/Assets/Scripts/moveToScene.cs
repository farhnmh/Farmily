using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class moveToScene : MonoBehaviour
{
    private Button ini;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        ini = GetComponent<Button>();
        ini.onClick.AddListener(move);
    }

    public void move()
    {
        SceneManager.LoadScene(sceneName);
    }
}
