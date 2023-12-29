using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public TrailRenderer trail;

    public static int numLives = 3;

    private void OnCollisionEnter(Collision collision)
    {
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        numLives--;
        trail.enabled = false;
        ball.transform.position = new Vector3(0, 10, 0);
        Invoke("turnOn", 1.5f);
    }

    void turnOn()
    {
        trail.enabled = true;
    }
}
