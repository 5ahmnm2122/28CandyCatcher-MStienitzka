using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerPhysics : MonoBehaviour
{
public Rigidbody player;
public int speed;

void Update()
{
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.AddForce(-speed,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.AddForce(speed, 0, 0);
        }
    }
}
