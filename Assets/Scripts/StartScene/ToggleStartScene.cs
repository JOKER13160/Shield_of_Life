using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStartScene : MonoBehaviour
{
    //offにするcanvasgroup
    [SerializeField] private CanvasGroup offCanvasGroup;
    //onにするcanvasgroup
    [SerializeField] private CanvasGroup onCanvasGroup;
    //クリック判定するボタン
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(ToggleCanvasGroup);
    }

    private void ToggleCanvasGroup()
    {
        offCanvasGroup.interactable = false;
        offCanvasGroup.alpha = 0f;
        offCanvasGroup.blocksRaycasts = false;

        onCanvasGroup.interactable = true;
        onCanvasGroup.alpha = 1f;
        onCanvasGroup.blocksRaycasts = true;
    }
}
