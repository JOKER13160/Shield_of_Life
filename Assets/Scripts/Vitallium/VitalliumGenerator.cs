using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VitalliumGenerator : MonoBehaviour
{
    //waitforseconds
    //初期値
    [SerializeField]public int startVitallium;
    //現在値
    [SerializeField]public int nowVitallium;
    //増える量
    [SerializeField]public int addVitallium;
    //最大値
    [SerializeField]public int maxVitallium;
    //テキスト
    [SerializeField] public TMP_Text vitalliumText;

    private void Start()
    {
        nowVitallium = startVitallium;
    }

    public IEnumerator TimeToVitallium()
    {
        while (true)
        {
            if (nowVitallium < maxVitallium)
            {
                nowVitallium = Mathf.Min(nowVitallium + addVitallium,maxVitallium);
                vitalliumText.text = nowVitallium.ToString();
            }
            yield return new WaitForSeconds(1f);
        }

    }
}
