using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string PlayerName;

    public void NewNameSelected(string name)
    {
        // add code here to handle when a name is entered
        MainManager.Instance.PlayerName = name;
    }
    
    private void Start()
    {
        // ColorPicker.Init();
        // //this will call the NewColorSelected function when the color picker have a color button clicked.
        // ColorPicker.onColorChanged += NewColorSelected;

        // ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MainManager.Instance.SavePlayerName();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void SavePlayerNameClicked()
    {
        MainManager.Instance.SavePlayerName();
    }

    // public void LoadColorClicked()
    // {
    //     MainManager.Instance.LoadColor();
    //     ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    // }
}