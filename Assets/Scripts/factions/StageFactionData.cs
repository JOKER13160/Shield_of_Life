using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// �X�L���̎��
/// </summary>
public enum Faction
{
    none,
    union,
    empire,
    machinica,
    knights,
    cult
    // ���ɂ�����Βǉ�

}

[Serializable]
public class StageFactionData
{
    public int id;
    public string stage;
    public Faction faction1;
    public Faction faction2;
    public Faction faction3;
    public Faction faction4;


    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="datas"></param>
    public StageFactionData(string[] datas)
    {

        // �擾�������̊m�F
        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
        }

        // �擾���������L���X�g���đ��
        id = int.Parse(datas[0]);
        stage = datas[1];
        faction1 = (Faction)Enum.Parse(typeof(Faction), datas[2]);
        faction2 = (Faction)Enum.Parse(typeof(Faction), datas[3]);
        faction3 = (Faction)Enum.Parse(typeof(Faction), datas[4]);
        faction4 = (Faction)Enum.Parse(typeof(Faction), datas[5]);
    }
}