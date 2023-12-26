using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public GameObject ball;

    public Text text;

    public float targetTime;

    float location;

    float _location;

    public ParticleSystem warning;

    private void Start()
    {
        targetTime = Random.Range(3, 10);
        location = Random.Range(-14, 14);
    }

    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            timerEnded();
            location = Random.Range(-14, 14);
        }
        if (targetTime >= 3.0f && targetTime <= 3.02f)
        {
            Instantiate(warning, new Vector3(0, 7, _location), warning.transform.rotation);
        }
        _location = location;

        text.text = Mathf.Round(targetTime).ToString();
    }

    void timerEnded()
    {
        targetTime = Random.Range(3, 10);
        ball.transform.position = new Vector3(0, ball.transform.position.y, location);
    }

}
