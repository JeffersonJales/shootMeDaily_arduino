using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CollisionDestroy : MonoBehaviour
{   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);    
    }

}
