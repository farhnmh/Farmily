using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class flowerBag : MonoBehaviour
{
    public int redFlower = 0;
    public int blueFlower = 0;
    public int purplePlant = 0;
    public int bluePlant = 0;

    public Text seedRedFlower;
    public Text seedBlueFlower;
    public Text seedPurplePlant;
    public Text seedBluePlant;

    // Update is called once per frame
    void Update()
    {
        seedRedFlower.text = redFlower.ToString();
        seedBlueFlower.text = blueFlower.ToString();
        seedPurplePlant.text = purplePlant.ToString();
        seedBluePlant.text = bluePlant.ToString();
    }
}
