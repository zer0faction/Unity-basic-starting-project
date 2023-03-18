using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUiController : UiController
{
    public void OnStartGame()
    {
        Debug.Log("ToDo: start the game!");
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}
