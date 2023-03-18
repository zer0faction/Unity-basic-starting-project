using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MainUiManager : Singleton<MainUiManager>
{
    [Header("References to other GameObjects/Components")]
    [SerializeField] private List<UiController> _uiControllers;

    private void Start()
    {
        foreach(var uiController in _uiControllers.Where(x => x.Index != 0))
            uiController.CanvasRenderer.enabled = false;
    }

    public void SwitchToController(UiController controllerFrom, int indexControllerTo)
    {
        var controllerTo = _uiControllers.First(x => x.Index == indexControllerTo);
        if (_uiControllers.Contains(controllerFrom) && controllerTo != null)
        {
            StartCoroutine(SwitchToComponentAsync(controllerFrom, controllerTo));
        }
        else
        {
            Debug.LogError("Impossible to switch UIControllers from " + controllerFrom.Index + " to " + indexControllerTo + ".");
        }
    }

    public void CloseMainMenu()
    {
        foreach (var controller in _uiControllers)
            controller.InstantUnload();
    }

    private IEnumerator SwitchToComponentAsync(UiController controllerFrom, UiController controllerTo)
    {
        yield return StartCoroutine(controllerFrom.OnUnload());
        yield return StartCoroutine(controllerTo.OnLoad());
    }
}
