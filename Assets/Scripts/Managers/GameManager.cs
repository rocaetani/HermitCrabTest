using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public GameObject Player;
    public StartPlatform StartPlatform;
    
    
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Start()
    {
        SceneController.Instance.OnPhaseLoaded += InitiatePhase;
    }

    public void EndPhase()
    {
        SceneController.Instance.LoadEndPhase();
    }

    public void InitiatePhase()
    {
        Player = GameObject.FindWithTag(TagManager.PLAYER_TAG);
        StartPlatform = GameObject.FindWithTag(TagManager.START_PLATFORM_TAG).GetComponent<StartPlatform>();
        RestartPhase();
    }

    public void RestartPhase()
    {
        StartPlatform.PositionPlayer(Player);
    }
}
