using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    PlayerMovement playerMove;
    ShootBullet playerFire;

    void Start()
    {
        playerMove = GetComponent<PlayerMovement>();
        playerFire = GetComponent<ShootBullet>();
    }

    void Update()
    {
        playerMove.Movement(Input.GetAxis("Horizontal"));
        if (Input.GetButton("Fire")) playerFire.CreateBullet(); 
    }
}
