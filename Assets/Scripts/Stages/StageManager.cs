using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;
    public VitalliumGenerator vitalliumGenerator;
    private Coroutine vitalliumCoroutine;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        vitalliumCoroutine = StartCoroutine(vitalliumGenerator.TimeToVitallium());
    }

    private void OnDisable()
    {
        // �R���[�`�����~�i�Q�[���I�u�W�F�N�g�������ɂȂ����Ƃ��j
        if (vitalliumCoroutine != null)
        {
            StopCoroutine(vitalliumCoroutine);
            Debug.Log("�R���[�`����~");
        }
    }
}
