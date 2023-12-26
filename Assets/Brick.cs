using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick : MonoBehaviour
{
    public Text health;
    public int curHealth;

    public ParticleSystem part;

    public void Start()
    {
        curHealth = Random.Range(1, 4);
    }

    public void Update()
    {
        health.text = curHealth.ToString();
        if (curHealth == 0)
        {
            Destroy(gameObject);
            Destroy(health.gameObject);
            Instantiate(part, gameObject.transform.position, Quaternion.identity);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        curHealth--;
    }
}
