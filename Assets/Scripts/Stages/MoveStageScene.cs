using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoveStageScene : MonoBehaviour,ISetup
{
    [SerializeField]
    private TMP_Dropdown dropdown;
    
    private List<TMP_Dropdown.OptionData> sceneNames;
    void Start()
    {
        
    }

    public void SetupLoadScene()
    {
        
    }

    // dropdown��option���I�����ꂽ�Ƃ��ɋN������֐�
    void LoadScene(int stageIndex)
    {
        // �I�����ꂽ�I�v�V�����̃��x�����擾
        sceneNames = dropdown.options;
        string sceneName = sceneNames[stageIndex].text;
        Debug.Log("Selected Option: " + sceneName);

        //�V�[�������݂��邩�m�F
        if (UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName) != null)
        {
            // �V�[�������[�h
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            Debug.Log(sceneName);

            GameManager.Instance.SetGameState(GameManager.GameState.play);
            Debug.Log("GameState : " + GameManager.Instance.gameState);
        }
        else
        {
            Debug.LogError("Scene not found: " + sceneName);
        }
    }

    public void Setup()
    {
        // dropdown��option���I�����ꂽ�Ƃ��ɋN������֐���ǉ�
        dropdown.onValueChanged.AddListener((value) => {
            LoadScene(value);
        });
    }
}
