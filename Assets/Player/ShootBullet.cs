using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class ShootBullet : MonoBehaviour
{
    public GameObject bulletRef;
    public GameObject bulletOrigin;

    public float intervalBetweenBullets = 30f;
    private float intervalCurrent = 0f;

    public void CreateBullet() {
        if (intervalCurrent > 0) return;
        Debug.Log("Bullet instantiate");
        Instantiate(bulletRef, bulletOrigin.transform.position, Quaternion.identity);
        intervalCurrent = intervalBetweenBullets;
    }

    private void FixedUpdate()
    {
        intervalCurrent--;
    }
}
