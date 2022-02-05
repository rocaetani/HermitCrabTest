using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Thrust;
    
    private Rigidbody _rigidbody;
    private bool _isGrounded;
    
    private Vector3 _lastFramePosition;
    private float _timeVerifier;
    private readonly float TIME_VERIFIER_RATE = 0.015f; //0.015 was the time limit rate tested that doesn't allow players jump twice in the air
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _isGrounded = true;
    }

    private void Update()
    {
        if (Time.time - _timeVerifier > TIME_VERIFIER_RATE)
        {
            if (Math.Abs(_lastFramePosition.y - transform.position.y) < 0.001)
            {
                _isGrounded = true;
            }
            _lastFramePosition = transform.position;
            _timeVerifier = Time.time;
        }
    }

    private void FixedUpdate()
    {
        if (InputController.Jump() & _isGrounded)
        {
            _isGrounded = false;
            _rigidbody.AddForce(transform.up * Thrust, ForceMode.Impulse);
        }
    }


 
}
