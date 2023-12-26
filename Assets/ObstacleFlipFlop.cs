using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFlipFlop : MonoBehaviour
{
    public GameObject obj;

    private void OnCollisionEnter(Collision collision)
    {
        obj.transform.Rotate(45, 0, 0, Space.World);
    }

}
