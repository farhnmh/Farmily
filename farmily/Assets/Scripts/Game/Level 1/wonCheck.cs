using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class wonCheck : MonoBehaviour
{
    public List<bool> done;
    public int progress;

    public int totalObjective;
    public int objectiveDone;
    
    public int organic;
    public int anorganic;
    public int diamond;
    public int gold;
    public int silver;

    public bool finished = false;
    public string ket = string.Empty;

    public int goldMedal;
    public int silverMedal;
    public int bronzeMedal;

    public Text totalOrganic;
    public Text totalAnorganic;
    public Text totalDiamond;
    public Text totalGold;
    public Text totalSilver;

    public timeScript time;
    public objectivePanel objective;
    public GameObject wonPanel;

    void Start()
    {
        for (int i = 0; i <= done.Capacity - 1; i++)
        {
            done[i] = false;
        }
    }

    void Update()
    {
        ket = PlayerPrefs.GetString("Level 1");
        if (objectiveDone == totalObjective && finished == false)
        {
            wonPanel.SetActive(true);
            progress = SceneManager.GetActiveScene().buildIndex - 4;

            if (ket == "Level 1")
            {
                PlayerPrefs.SetInt("Progress Level", progress);
            }

            if (time.timerMinute == 0 && time.timerSecond <= 40 && ket == "Level 1")
            {
                goldMedal = PlayerPrefs.GetInt("Gold Medal");
                PlayerPrefs.SetInt("Gold Medal", goldMedal + 1);
            }
            else if (time.timerMinute == 0 && 40 < time.timerSecond && time.timerSecond <= 60 && ket == "Level 1" ||
                     time.timerMinute == 1 && 0 <= time.timerSecond && time.timerSecond < 30 && ket == "Level 1")
            {
                silverMedal = PlayerPrefs.GetInt("Silver Medal");
                PlayerPrefs.SetInt("Silver Medal", silverMedal + 1);
            }
            else if (time.timerMinute == 1 && 30 < time.timerSecond && time.timerSecond <= 60 && ket == "Level 1" ||
                     time.timerMinute == 2 && 0 <= time.timerSecond && time.timerSecond <= 10 && ket == "Level 1")
            {
                bronzeMedal = PlayerPrefs.GetInt("Bronze Medal");
                PlayerPrefs.SetInt("Bronze Medal", bronzeMedal + 1);
            }

            PlayerPrefs.SetString("Level 1", "Level 1 is done");
            finished = true;
        }

        totalAnorganic.text = anorganic.ToString();
        totalOrganic.text = organic.ToString();
        totalDiamond.text = diamond.ToString();
        totalGold.text = gold.ToString();
        totalSilver.text = silver.ToString();

        if (objective.firstStringObjective == "Anorganic Trash" && objective.firstNumberObjective == anorganic && done[0] == false || 
            objective.secondStringObjective == "Anorganic Trash" && objective.secondNumberObjective == anorganic && done[0] == false)
        {
            objectiveDone += 1;
            done[0] = true;
        }

        if (objective.firstStringObjective == "Organic Trash" && objective.firstNumberObjective == organic && done[1] == false ||
            objective.secondStringObjective == "Organic Trash" && objective.secondNumberObjective == organic && done[1] == false)
        {
            objectiveDone += 1;
            done[1] = true;
        }

        if (objective.firstStringObjective == "Diamond" && objective.firstNumberObjective == diamond && done[2] == false || 
            objective.secondStringObjective == "Diamond" && objective.secondNumberObjective == diamond && done[2] == false)
        {
            objectiveDone += 1;
            done[2] = true;
        }

        if (objective.firstStringObjective == "Gold" && objective.firstNumberObjective == gold && done[3] == false || 
            objective.secondStringObjective == "Gold" && objective.secondNumberObjective == gold && done[3] == false)
        {
            objectiveDone += 1;
            done[3] = true;
        }

        if (objective.firstStringObjective == "Silver" && objective.firstNumberObjective == silver && done[4] == false || 
            objective.secondStringObjective == "Silver" && objective.secondNumberObjective == silver && done[4] == false)
        {
            objectiveDone += 1;
            done[4] = true;
        }
    }
}