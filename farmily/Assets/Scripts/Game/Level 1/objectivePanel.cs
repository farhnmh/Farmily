using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class objectivePanel : MonoBehaviour
{
    public string firstCommand;
    public string secondCommand;
    public string firstStringObjective;
    public string secondStringObjective;
    public int firstNumberObjective;
    public int secondNumberObjective;
    
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
    }
}
