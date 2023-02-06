using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveManager : MonoBehaviour
{
    #region SingleTon
    public static LoadSaveManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }
    #endregion

    public void LoadGame()
    {

    }

    public void SaveGame()
    {

    }
}
