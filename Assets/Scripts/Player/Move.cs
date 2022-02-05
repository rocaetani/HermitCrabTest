using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float Speed;

    // Update is called once per frame
    void Update()
    {
        MoveUpdate();
    }

    private void MoveUpdate()
    {
        Vector3 position = transform.position;
        position = position + (Speed * InputController.MoveHorizontal() * Time.deltaTime * Vector3.right);
        transform.position = position;
    }
    
}
