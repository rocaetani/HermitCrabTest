using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Life { get; private set; }

    private GameManager _gameManager;
    

    private void Start()
    {
        Life = 3;
        _gameManager = GameManager.Instance;
    }

    public void ReduceLife()
    {
        Life -= 1;
        
        if (Life == 0)
        {
            _gameManager.EndPhase();
        }
        else
        {
            _gameManager.RestartPhase();
        }

        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(TagManager.KILLER_TOUCH_TAG))
        {
            ReduceLife();
        }
    }
}
        