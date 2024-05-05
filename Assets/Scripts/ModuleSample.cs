using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ModuleSample : MonoBehaviour
{
    public MODRarityType modRarityType;
    public string modName;

    public void SetUp()
    {
        MODRarityType RandomType = 
            (MODRarityType)UnityEngine.Random.Range(0, Enum.GetValues(typeof( MODRarityType)).Length);
        modRarityType = RandomType;
        modName = RandomType.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
