using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;

    public int playerPos = 3;

    private void Update()
    {
        if(playerPos >= 2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                player.position = new Vector3(player.position.x, player.position.y, player.position.z - 6);
                playerPos--;
            }
        }
        if(playerPos <= 4)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                player.position = new Vector3(player.position.x, player.position.y, player.position.z + 6);
                playerPos++;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddExplosionForce(30, player.position, 3, 3, ForceMode.VelocityChange);
    }
}
