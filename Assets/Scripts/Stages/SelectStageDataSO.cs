using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create SelectStageDataSO", fileName = "SelectStageDataSO")]
public class SelectStageDataSO : ScriptableObject
{
    public List<SelectStageData> SelectStageDatasList = new();
}