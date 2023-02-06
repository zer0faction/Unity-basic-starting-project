using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInputManager : MonoBehaviour
{
    [Header("Input settings")]
    [SerializeField] private float controllerAxisMin = .35f;

    private List<IInputReader> _inputReaders;

    private void Start()
    {
        _inputReaders = new List<IInputReader>();
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        int right = 0;
        int left = 0;
        int up = 0;
        int down = 0;

        if (inputX > controllerAxisMin) { right = 1; }
        if (inputX < -controllerAxisMin) { left = 1; }
        if (inputY > controllerAxisMin) { up = 1; }
        if (inputY < -controllerAxisMin) { down = 1; }

        ButtonInputData buttonInputData = new ButtonInputData
        {
            x = (right - left),
            y = (up - down),
        };

        foreach (IInputReader inputReader in _inputReaders)
        {
            inputReader.ReceiveButtonInput(buttonInputData);
        }
    }
}
