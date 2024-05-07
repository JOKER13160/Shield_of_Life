using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// ストーリーの章の分類
/// </summary>
public enum chapter
{
    demo,
    一章,
    二章,
    三章
    // 他にもあれば追加

}

[Serializable]
public class SelectStageData
{
    public int id;
    public chapter chapter;
    public string stage;
    public string description;


    /// <summary>
    /// コストラクタ
    /// </summary>
    /// <param name="datas"></param>
    public SelectStageData(string[] datas)
    {

        // 取得した情報の確認
        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
        }

        // 取得した情報をキャストして代入
        id = int.Parse(datas[0]);
        chapter = (chapter)Enum.Parse(typeof(chapter), datas[1]);
        stage = datas[2];
        description = datas[3];
    }
}