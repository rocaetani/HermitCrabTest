using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void StartScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
