using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputReader
{
    public void ReceiveButtonInput(ButtonInputData buttonInputData);
}
