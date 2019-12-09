using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collectorScriptLevel3 : MonoBehaviour
{
    public int organicCollect;
    public int anorganicCollect;

    public float time = 0;
    public bool please = false;
    public bool find = false;
    public Button fix;
    public Button cancel;
    public GameObject testAgain;

    public GameObject fixButton;
    public GameObject cancelButton;

    public Button organic;
    public Button anorganic;
    public Text totalOrganic;
    public Text totalAnorganic;

    public flowerBag bag;
    public wonCheckLevel3 won;
    public objectivePanelLevel3 obj;

    void Start()
    {
        organic.onClick.AddListener(clickOrganic);
        anorganic.onClick.AddListener(clickAnorganic);

        cancel.onClick.AddListener(Cancel);
        fix.onClick.AddListener(Fix);

        fixButton.SetActive(false);
        cancelButton.SetActive(false);
        testAgain.SetActive(false);
    }

    void Update()
    {
        totalOrganic.text = organicCollect.ToString();
        totalAnorganic.text = anorganicCollect.ToString();

        if (please == true)
        {
            Cancel();
            time += 1 * Time.deltaTime;
            if (time >= 3)
            {
                time = 0;
                testAgain.SetActive(false);
                please = false;
            }
        }
    }

    void clickOrganic()
    {
        if (won.organic > 0)
        {
            won.organic -= 1;
            organicCollect += 1;
        }

        if (organicCollect != 0) {
            fixButton.SetActive(true);
            cancelButton.SetActive(true);
        }
    }

    void clickAnorganic()
    {
        if (won.anorganic > 0)
        {
            won.anorganic -= 1;
            anorganicCollect += 1;
        }

        if (anorganicCollect != 0)
        {
            fixButton.SetActive(true);
            cancelButton.SetActive(true);
        }
    }

    void Fix()
    {
        fixButton.SetActive(false);
        cancelButton.SetActive(false);

        //redflower
        if (organicCollect == 1 && anorganicCollect == 0)
        {
            Debug.Log("redFlower");
            bag.redFlower += 1;
            organicCollect = 0;
            anorganicCollect = 0;
            find = true;
        }
        
        //blueflower
        else if (organicCollect == 1 && anorganicCollect == 1)
        {
            Debug.Log("blueFlower");
            bag.blueFlower += 1;
            organicCollect = 0;
            anorganicCollect = 0;
            find = true;
        }
        
        //purpleplant
        else if (organicCollect == 1 && anorganicCollect == 2)
        {
            Debug.Log("purplePlant");
            bag.purplePlant += 1;
            organicCollect = 0;
            anorganicCollect = 0;
            find = true;
        }
        
        //blueplant
        else if (organicCollect == 3 && anorganicCollect == 2)
        {
            Debug.Log("bluePlant");
            bag.bluePlant += 1;
            organicCollect = 0;
            anorganicCollect = 0;
            find = true;
        }

        if (find == false)
        {
            testAgain.SetActive(true);
            please = true;
        }

        find = false;
    }

    void Cancel()
    {
        won.organic += organicCollect;
        won.anorganic += anorganicCollect;

        organicCollect = 0;
        anorganicCollect = 0;

        fixButton.SetActive(false);
        cancelButton.SetActive(false);
    }
}
