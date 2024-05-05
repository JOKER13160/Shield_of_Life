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
        // �h���b�v�_�E���̃I�v�V�������X�N���v�^�u���I�u�W�F�N�g����擾���Đݒ肷��
        List<string> options = new List<string>();
        foreach (var stageData in SelectStageDataSO.SelectStageDatasList)
        {
            // �X�e�[�W�̏����h���b�v�_�E���̃I�v�V�����Ƃ��Ēǉ�����
            options.Add(stageData.stage);
        }

        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }
}