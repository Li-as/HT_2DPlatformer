using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private bool _isMovingLeft;


    private void Update()
    {
        if (_isMovingLeft)
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime * -1);
        }
        else
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }

    public void ChangeDirection()
    {
        if (_isMovingLeft)
        {
            _isMovingLeft = false;
        }
        else
        {
            _isMovingLeft = true;
        }
    }
}
