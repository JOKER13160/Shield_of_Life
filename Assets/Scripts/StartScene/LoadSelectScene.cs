using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSelectScene : MonoBehaviour
{
    // ボタンを参照するための変数
    public Button switchButton;

    // 切り替えるシーンの名前
    public string sceneToLoad;

    void Start()
    {
        // ボタンがクリックされたときに呼び出すメソッドを設定
        switchButton.onClick.AddListener(SwitchScene);
    }

    // シーンを切り替えるメソッド
    void SwitchScene()
    {
        // シーンを切り替える
        SceneManager.LoadScene(sceneToLoad);
    }
}
