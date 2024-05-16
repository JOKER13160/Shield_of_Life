using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create StageDisasterDataSO", fileName = "StageDisasterDataSO")]
public class StageDisasterDataSO : ScriptableObject
{
    public List<StageDisasterData> stageDisasterDatasList = new();
}