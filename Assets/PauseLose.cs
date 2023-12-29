using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PauseLose : MonoBehaviour
{
    public Canvas game;
    public Canvas pause;

    public Text lose;
    public Text paused;

    public Text timer;

    Boolean isPaused = false;

    public Rigidbody ball;

    private void Start()
    {
        lose.enabled = false;
        paused.enabled = true;
        game.enabled = true;
        pause.enabled = false;
    }

    private void Update()
    {
        timer.enabled = true;
        if (Lives.alive == 1)
        {
            lose.enabled = true;
            paused.enabled = false;
            ball.useGravity = false;
            ball.velocity = Vector3.zero;
            game.enabled = false;
            pause.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            game.enabled = false;
            pause.enabled = true;
            isPaused = true;
            ball.useGravity = false;
            ball.velocity = Vector3.zero;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            game.enabled = true;
            pause.enabled = false;
            isPaused = false;
            ball.useGravity = true;
        }
    }

    public void quit() 
    { 
        Application.Quit();
    }

}
