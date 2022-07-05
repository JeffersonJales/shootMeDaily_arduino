using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantLinearMovement : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    private Vector3 moveDirection;

    private Vector3 Direction
    {
        get { return direction; }
        set {
            direction = value;
            UpdateMoveDirection();
        }
    }
    private float Speed {
        get { return speed; } 
        set {
            speed = value;
            UpdateMoveDirection();
        } 
    }
   

    private void UpdateMoveDirection() { 
        moveDirection = direction * speed;
    }

    private void MoveGameObject() {
        transform.Translate(moveDirection);
    }

    private void Start()
    {
        UpdateMoveDirection();
    }

    void FixedUpdate()
    {
        MoveGameObject();
    }
}
