using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class musicCondition : MonoBehaviour
{
    private GameObject audio;
    public Button bgm;
    public GameObject yes;
    public GameObject no;

    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("audio");
        bgm.onClick.AddListener(bgmCondition);
    }

    void Update()
    {
        if (audio.GetComponent<AudioSource>().mute == false)
        {
            yes.SetActive(true);
            no.SetActive(false);
        }
        else if (audio.GetComponent<AudioSource>().mute == true)
        {
            yes.SetActive(false);
            no.SetActive(true);
        }
    }

    public void bgmCondition()
    {
        if (audio.GetComponent<AudioSource>().mute == false)
        {
            audio = GameObject.FindGameObjectWithTag("audio");
            audio.GetComponent<AudioSource>().mute = true;
        }
        else if (audio.GetComponent<AudioSource>().mute == true)
        {
            audio = GameObject.FindGameObjectWithTag("audio");
            audio.GetComponent<AudioSource>().mute = false;
        }
    }
}
