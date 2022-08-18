using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Quits the player when the user hits escape

public class ExitButtonClick : MonoBehaviour
{
    public void Click()
    {
        {
            Application.Quit();    // закрыть приложение
        }
    }
}

