using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    [Header("References to other GameObjects/Components")]
    public Canvas CanvasRenderer;

    public int Index;

    public virtual IEnumerator OnLoad()
    {
        CanvasRenderer.enabled = true;
        yield return null;
    }

    public virtual IEnumerator OnUnload()
    {
        CanvasRenderer.enabled = false;
        yield return null;
    }

    public void InstantUnload()
    {
        CanvasRenderer.enabled = false;
    }
}
