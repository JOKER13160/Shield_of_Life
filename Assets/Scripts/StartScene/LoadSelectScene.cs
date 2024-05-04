using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSelectScene : MonoBehaviour
{
    // �{�^�����Q�Ƃ��邽�߂̕ϐ�
    public Button switchButton;

    // �؂�ւ���V�[���̖��O
    public string sceneToLoad;

    void Start()
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����\�b�h��ݒ�
        switchButton.onClick.AddListener(SwitchScene);
    }

    // �V�[����؂�ւ��郁�\�b�h
    void SwitchScene()
    {
        // �V�[����؂�ւ���
        SceneManager.LoadScene(sceneToLoad);
    }
}
