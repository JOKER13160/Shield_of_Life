using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ChangeStageDataDropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SelectStageDataSO SelectStageDataSO;

    void Start()
    {
        // ドロップダウンのオプションをスクリプタブルオブジェクトから取得して設定する
        List<string> options = new List<string>();
        foreach (var stageData in SelectStageDataSO.SelectStageDatasList)
        {
            // ステージの情報をドロップダウンのオプションとして追加する
            options.Add(stageData.stage);
        }

        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }
}