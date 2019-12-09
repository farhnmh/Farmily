using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class medalScript : MonoBehaviour
{
    public int goldMedal;
    public int silverMedal;
    public int bronzeMedal;

    public Text gold;
    public Text silver;
    public Text bronze;

    // Update is called once per frame
    void Update()
    {
        goldMedal = PlayerPrefs.GetInt("Gold Medal");
        silverMedal = PlayerPrefs.GetInt("Silver Medal");
        bronzeMedal = PlayerPrefs.GetInt("Bronze Medal");

        gold.text = goldMedal.ToString();
        silver.text = silverMedal.ToString();
        bronze.text = bronzeMedal.ToString();
    }
}
