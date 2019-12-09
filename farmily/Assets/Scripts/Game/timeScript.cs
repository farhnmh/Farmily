using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timeScript : MonoBehaviour
{
    public int timerMinute;
    public int timerSecond;

    public Text timer;

    private void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerSecond >= 60)
        {
            timerSecond = 0;
            timerMinute++;
        }
        
        timer.text = "";
        timer.text += "< ";
        if(timerMinute < 10)
        {
            timer.text += "0";
        }
        timer.text += timerMinute.ToString("0") + " : ";
        if(timerSecond < 10)
        {
            timer.text += "0";
        }
        timer.text += timerSecond.ToString("0") + " >";
    }

    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(1);
        timerSecond++;
        StartCoroutine("Timer");
    }
}
