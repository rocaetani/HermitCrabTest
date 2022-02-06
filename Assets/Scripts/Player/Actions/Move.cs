using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float Speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveUpdate();
    }

    private void MoveUpdate()
    {
        //Vector3 position = transform.position;
        Vector3 position = (Speed * InputController.MoveHorizontal() * Time.deltaTime * transform.right);
        //position = position + (Speed * InputController.MoveHorizontal() * Time.deltaTime * Vector3.right);

        _rigidbody.velocity = new Vector3(position.x, _rigidbody.velocity.y, _rigidbody.velocity.z);;
    }
    
}
