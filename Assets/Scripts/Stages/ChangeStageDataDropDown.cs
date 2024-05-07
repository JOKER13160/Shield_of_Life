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
        //�I�v�V�����z���������
        dropdown.ClearOptions();
        //�V�����I�v�V������ݒ�
        List<string> options = new List<string>();
        //SO��Chapter���擾
        //Chapter�ǂ����Ŕ�r
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