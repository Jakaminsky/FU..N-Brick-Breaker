using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static int win = 0;

    void Update()
    {
        if(win == 52)
        {
            SceneManager.LoadScene(2);
        }
    }
}
