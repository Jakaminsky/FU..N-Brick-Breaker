using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void Start()
    {
        Invoke("End", 12);
    }

    void End()
    {
        Application.Quit();
    }
}
