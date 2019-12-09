using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class objectivePanelLevel3 : MonoBehaviour
{
    public string firstCommand;
    public int firstNumberObjective;
    public string firstStringObjective;

    public string secondCommand;
    public int secondNumberObjective;
    public string secondStringObjective;

    
    public Text firstObjective;
    public Text secondObjective;

    void Start()
    {
        gameObject.SetActive(false);    
    }

    void Update()
    {
        firstObjective.text = firstCommand + " " + firstNumberObjective + " " + firstStringObjective;
        secondObjective.text = secondCommand + " " + secondNumberObjective + " " + secondStringObjective;

        if (firstNumberObjective == 0)
        {
            firstObjective.text = string.Empty;
        }
        if (secondNumberObjective == 0)
        {
            secondObjective.text = string.Empty;
        }
    }
}
