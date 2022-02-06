using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Thrust;
    
    private Rigidbody _rigidbody;
    private bool _isGrounded;

    private bool _shouldJump;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _isGrounded = true;
        _shouldJump = false;
    }

    private void Update()
    {
        if (InputController.Jump())
        {
            _shouldJump = true;
        }
    }

    private void FixedUpdate()
    {
        if (_shouldJump & _isGrounded)
        {
            _isGrounded = false;
            _rigidbody.AddForce(transform.up * Thrust, ForceMode.Impulse);
        }

        _shouldJump = false;
    }


    public void OnCollisionEnter(Collision other)
    {
        _isGrounded = true;
    }
}
