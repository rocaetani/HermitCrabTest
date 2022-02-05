using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static float MoveHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public static bool Jump()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
}
