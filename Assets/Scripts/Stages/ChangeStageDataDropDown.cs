using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using System.Linq;

public class ChangeStageDataDropDown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TMP_Text Label;
    [SerializeField] private SelectStageDataSO SelectStageDataSO;
    [SerializeField] private chapter chapter;

    void Start()
    {
        //オプション配列を初期化
        dropdown.ClearOptions();
        //新しいオプションを設定
        List<string> options = new List<string>();
        //SOのChapterを取得
        //Chapterどうしで比較
        for (int i = 0; i < SelectStageDataSO.SelectStageDatasList.Count; i++)
        { 
            if (chapter == SelectStageDataSO.SelectStageDatasList[i].chapter)
            {
                options.Add(SelectStageDataSO.SelectStageDatasList[i].stage);
                
                
            }
        }
        dropdown.AddOptions(options);
        Label.text = chapter.ToString();
        Debug.Log("Label.text : " + Label.text);
    }
}