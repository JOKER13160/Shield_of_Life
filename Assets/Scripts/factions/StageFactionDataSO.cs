using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create StageFactionDataSO", fileName = "StageFactionDataSO")]
public class StageFactionDataSO : ScriptableObject
{
    public List<StageFactionData> stageFactionDatasList = new();
}