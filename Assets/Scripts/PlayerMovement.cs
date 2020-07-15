using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private float _horizontalMovement;
    private bool _isJumping;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal") * _speed;

        if (_horizontalMovement > 0)
        {
            transform.rotation = Quaternion.identity;
        }
        else if (_horizontalMovement < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }

        if (_horizontalMovement != 0)
        {
            _animator.SetFloat("Speed", 1);
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumping = true;
        }

    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_horizontalMovement * Time.fixedDeltaTime, 0);

        if (_isJumping)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _isJumping = false;
        }
    }
}
