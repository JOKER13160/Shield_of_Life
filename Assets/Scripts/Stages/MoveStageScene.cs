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

    // dropdownのoptionが選択されたときに起動する関数
    void LoadScene(int stageIndex)
    {
        // 選択されたオプションのラベルを取得
        sceneNames = dropdown.options;
        string sceneName = sceneNames[stageIndex].text;
        Debug.Log("Selected Option: " + sceneName);

        //シーンが存在するか確認
        if (UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName) != null)
        {
            // シーンをロード
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
        // dropdownのoptionが選択されたときに起動する関数を追加
        dropdown.onValueChanged.AddListener((value) => {
            LoadScene(value);
        });
    }
}
