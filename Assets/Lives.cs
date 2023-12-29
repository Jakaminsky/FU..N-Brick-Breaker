using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text lives;

    public static int numLives = 3;

    public static int alive = 0;

    private void Start()
    {
        lives.text = numLives.ToString();
    }

    private void Update()
    {
        if (numLives == 0)
        {
            alive = 1;
        }
        numLives = Ball.numLives;
        lives.text = numLives.ToString();
    }
}
