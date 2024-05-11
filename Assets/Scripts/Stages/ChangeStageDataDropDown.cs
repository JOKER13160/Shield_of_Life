using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeStageDataDropDown : MonoBehaviour,ISetup,IPointerDownHandler
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TMP_Text Label;
    [SerializeField] private SelectStageDataSO SelectStageDataSO;
    [SerializeField] private chapter chapter;

    void Start()
    {
        
        
    }

    public void StageSetup()
    {
        
    }

    public void Setup()
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
                Debug.Log("stage : " + SelectStageDataSO.SelectStageDatasList[i].stage);

            }
        }
        dropdown.AddOptions(options);
        Label.text = chapter.ToString();
        Debug.Log("ラベルテキスト : " + Label.text);
        dropdown.value = 10;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("ww");
    }
}