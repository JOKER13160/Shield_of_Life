using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// スキルの種類
/// </summary>
public enum Disaster
{
    rain,
    lightning,
    tornade,
    poisonTile,
    magma,
    voidHole
    // 他にもあれば追加

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
    /// コンストラクタ
    /// </summary>
    /// <param name="datas"></param>
    public StageDisasterData(string[] datas)
    {

        // 取得した情報の確認
        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
        }

        // 取得した情報をキャストして代入
        id = int.Parse(datas[0]);
        disaster = (Disaster)Enum.Parse(typeof(Disaster), datas[1]);
        disasterType = (DisasterType)Enum.Parse(typeof(DisasterType), datas[2]);
    }
}