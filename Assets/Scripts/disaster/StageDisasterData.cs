using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// �X�L���̎��
/// </summary>
public enum Disaster
{
    rain,
    lightning,
    tornade,
    poisonTile,
    magma,
    voidHole
    // ���ɂ�����Βǉ�

}

public enum DisasterType
{
    weather,
    tile
}

[Serializable]
public class StageDisasterData
{
    public int id;
    public Disaster disaster;
    public DisasterType disasterType;


    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="datas"></param>
    public StageDisasterData(string[] datas)
    {

        // �擾�������̊m�F
        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
        }

        // �擾���������L���X�g���đ��
        id = int.Parse(datas[0]);
        disaster = (Disaster)Enum.Parse(typeof(Disaster), datas[1]);
        disasterType = (DisasterType)Enum.Parse(typeof(DisasterType), datas[2]);
    }
}