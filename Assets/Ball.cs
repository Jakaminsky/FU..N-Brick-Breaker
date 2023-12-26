using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public TrailRenderer trail;

    private void OnCollisionEnter(Collision collision)
    {
        trail.enabled = false;
        ball.transform.position = new Vector3(0, 10, 0);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Invoke("turnOn", 1.5f);
    }

    void turnOn()
    {
        trail.enabled = true;
    }
}
