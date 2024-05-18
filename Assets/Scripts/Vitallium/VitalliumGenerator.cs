using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VitalliumGenerator : MonoBehaviour
{
    //waitforseconds
    //�����l
    [SerializeField]public int startVitallium;
    //���ݒl
    [SerializeField]public int nowVitallium;
    //�������
    [SerializeField]public int addVitallium;
    //�ő�l
    [SerializeField]public int maxVitallium;
    //�e�L�X�g
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
