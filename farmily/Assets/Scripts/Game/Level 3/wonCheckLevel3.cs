using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class wonCheckLevel3 : MonoBehaviour
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
    public collectorScriptLevel3 coll;
    public objectivePanelLevel3 objective;
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
        ket = PlayerPrefs.GetString("Level 3");
        if (objectiveDone == totalObjective && finished == false)
        {
            wonPanel.SetActive(true);
            progress = SceneManager.GetActiveScene().buildIndex - 4;

            if (ket == "Level 3")
            {
                PlayerPrefs.SetInt("Progress Level", progress);
            }

            if (time.timerMinute == 0 && time.timerSecond <= 40 && ket == "Level 3")
            {
                goldMedal = PlayerPrefs.GetInt("Gold Medal");
                PlayerPrefs.SetInt("Gold Medal", goldMedal + 1);
            }
            else if (time.timerMinute == 0 && 40 < time.timerSecond && time.timerSecond <= 60 && ket == "Level 3" ||
                     time.timerMinute == 1 && 0 <= time.timerSecond && time.timerSecond < 30 && ket == "Level 3")
            {
                silverMedal = PlayerPrefs.GetInt("Silver Medal");
                PlayerPrefs.SetInt("Silver Medal", silverMedal + 1);
            }
            else if (time.timerMinute == 1 && 30 < time.timerSecond && time.timerSecond <= 60 && ket == "Level 3" ||
                     time.timerMinute == 2 && 0 <= time.timerSecond && time.timerSecond <= 10 && ket == "Level 3")
            {
                bronzeMedal = PlayerPrefs.GetInt("Bronze Medal");
                PlayerPrefs.SetInt("Bronze Medal", bronzeMedal + 1);
            }

            PlayerPrefs.SetString("Level 3", "Level 3 is done");
            finished = true;
        }

        totalAnorganic.text = anorganic.ToString();
        totalOrganic.text = organic.ToString();
        totalDiamond.text = diamond.ToString();
        totalGold.text = gold.ToString();
        totalSilver.text = silver.ToString();

        //Collect
        if (objective.firstCommand == "Collect" || objective.secondCommand == "Collect")
        {
            //Organic Trash
            if (objective.firstCommand == "Collect" && organic == objective.firstNumberObjective && objective.firstStringObjective == "Organic Trash" && done[0] == false ||
                objective.secondCommand == "Collect" && organic == objective.secondNumberObjective && objective.secondStringObjective == "Organic Trash" && done[0] == false)
            {
                objectiveDone += 1;
                done[0] = true;
            }

            //Anorganic Trash
            if (objective.firstCommand == "Collect" && anorganic == objective.firstNumberObjective && objective.firstStringObjective == "Anorganic Trash" && done[1] == false ||
                objective.secondCommand == "Collect" && anorganic == objective.secondNumberObjective && objective.secondStringObjective == "Anorganic Trash" && done[1] == false)
            {
                objectiveDone += 1;
                done[1] = true;
            }

            //Diamond
            if (objective.firstCommand == "Collect" && diamond == objective.firstNumberObjective && objective.firstStringObjective == "Diamond" && done[2] == false ||
                objective.secondCommand == "Collect" && diamond == objective.secondNumberObjective && objective.secondStringObjective == "Diamond" && done[2] == false)
            {
                objectiveDone += 1;
                done[2] = true;
            }

            //Gold
            if (objective.firstCommand == "Collect" && gold == objective.firstNumberObjective && objective.firstStringObjective == "Gold" && done[3] == false ||
                objective.secondCommand == "Collect" && gold == objective.secondNumberObjective && objective.secondStringObjective == "Gold" && done[3] == false)
            {
                objectiveDone += 1;
                done[3] = true;
            }

            //Silver
            if (objective.firstCommand == "Collect" && silver == objective.firstNumberObjective && objective.firstStringObjective == "Silver" && done[4] == false ||
                objective.secondCommand == "Collect" && silver == objective.secondNumberObjective && objective.secondStringObjective == "Silver" && done[4] == false)
            {
                objectiveDone += 1;
                done[4] = true;
            }
        }

        //Invest
        if (objective.firstCommand == "Invest" || objective.secondCommand == "Invest")
        {
            if (objective.firstCommand == "Invest" && coll.organicCollect == objective.firstNumberObjective && objective.secondStringObjective == "Organic Trash" && done[5] == false ||
                objective.secondCommand == "Invest" && coll.organicCollect == objective.secondNumberObjective && objective.secondStringObjective == "Organic Trash" && done[5] == false)
            {
                objectiveDone += 1;
                done[5] = true;
            }

            if (objective.firstCommand == "Invest" && coll.anorganicCollect == objective.firstNumberObjective && objective.firstStringObjective == "Anorganic Trash" && done[6] == false ||
                objective.secondCommand == "Invest" && coll.anorganicCollect == objective.secondNumberObjective && objective.secondStringObjective == "Anorganic Trash" && done[6] == false)
            {
                objectiveDone += 1;
                done[6] = true;
            }
        }

        //Plant
        if (objective.firstCommand == "Invest" || objective.secondCommand == "Invest")
        {

        }
    }
}