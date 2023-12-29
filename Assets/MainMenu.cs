using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text title;
    public Button start;

    public Animator anim;
    public Text countdown;
    public int down = 3;

    private void Start()
    {
        title.enabled = true;
        start.enabled = true;
        countdown.enabled = false;
        countdown.text = down.ToString();
    }

    private void Update()
    {
        countdown.text = down.ToString();
    }
    public void StartGame()
    {
        title.enabled = false;
        start.GetComponent<RectTransform>().position = new Vector3(0, 2000, 0);
        countdown.enabled = true;
        anim.SetTrigger("Active");
        Invoke("Down", 1f);
        Invoke("Down", 2);
        Invoke("DoIt", 3f);
    }

    void Down()
    {
        down--;
    }

    void DoIt()
    {
        SceneManager.LoadScene(1);
    }
}
