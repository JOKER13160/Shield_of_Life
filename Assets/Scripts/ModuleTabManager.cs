using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public enum ModuleTabType
{
    SetModule,
    LvUPModule
}
public class ModuleTabManager : MonoBehaviour
{
    public Button[] ModuleTabButtons;
    public GameObject Container1;
    public GameObject Container2;

    private void Start()
    {
        for(int i = 0; i< ModuleTabButtons.Length; i++)
        {
            int index = i;
            ModuleTabButtons[index].onClick.AddListener(() => SwitchModuleTab((ModuleTabType)index));
        }
    }

    private void SwitchModuleTab(ModuleTabType moduleTabType)
    {
        switch (moduleTabType)
        {
            case ModuleTabType.SetModule:
                OnClickSetModule();
                break;
            case ModuleTabType.LvUPModule:
                OnClickLvUPModule();
                break;
        }
    }

    private void OnClickSetModule()
    {
        //mod”z’u‰æ–Ê
        Container1.SetActive(true);
        Container2.SetActive(false);
        Debug.Log("OnClickSetModule");
    }

    private void OnClickLvUPModule()
    {
        //modLvUP‰æ–Ê
        Container2.SetActive(true);
        Container1.SetActive(false);
        Debug.Log("OnClickLvUPModule");
    }
}
