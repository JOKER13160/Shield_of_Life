using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// �X�g�[���[�̏͂̕���
/// </summary>
public enum chapter
{
    demo,
    ���,
    ���,
    �O��
    // ���ɂ�����Βǉ�

}

[Serializable]
public class SelectStageData
{
    public int id;
    public chapter chapter;
    public string stage;
    public string description;


    /// <summary>
    /// �R�X�g���N�^
    /// </summary>
    /// <param name="datas"></param>
    public SelectStageData(string[] datas)
    {

        // �擾�������̊m�F
        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
        }

        // �擾���������L���X�g���đ��
        id = int.Parse(datas[0]);
        chapter = (chapter)Enum.Parse(typeof(chapter), datas[1]);
        stage = datas[2];
        description = datas[3];
    }
}