using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collectorScript : MonoBehaviour
{
    public int organicCollect;
    public int anorganicCollect;
    
    public Button organic;
    public Button anorganic;
    public Text totalOrganic;
    public Text totalAnorganic;

    public wonCheckLevel2 won;
    public objectivePanelLevel2 obj;

    void Start()
    {
        organic.onClick.AddListener(clickOrganic);    
        anorganic.onClick.AddListener(clickAnorganic);    
    }

    void Update()
    {
        totalOrganic.text = organicCollect.ToString();
        totalAnorganic.text = anorganicCollect.ToString();
    }

    void clickOrganic()
    {
        if (won.organic > 0)
        {
            won.organic -= 1;
            organicCollect += 1;
        }
    }

    void clickAnorganic()
    {
        if (won.anorganic > 0)
        {
            won.anorganic -= 1;
            anorganicCollect += 1;
        }
    }
}
