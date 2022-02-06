using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    public void PositionPlayer(GameObject player)
    {
        player.transform.position = new Vector3(transform.position.x, 2, transform.position.z );

    }

}
