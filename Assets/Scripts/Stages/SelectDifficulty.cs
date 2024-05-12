using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    [SerializeField]private TMP_Dropdown dropdown;

    public enum Difficulty
    {
        easy,
        normal,
        hard,
        dynamic
    }
    void Start()
    {
        dropdown.ClearOptions();
        List<string> options = new List<string>();
        //enum‚Ì—v‘f‚ðoption‚É’Ç‰Á
        dropdown.AddOptions(new List<string>(Enum.GetNames(typeof(Difficulty))));
    }
}
