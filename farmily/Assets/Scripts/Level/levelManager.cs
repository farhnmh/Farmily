using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public int levelSelect;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}