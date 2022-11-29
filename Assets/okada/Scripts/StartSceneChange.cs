using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    [SerializeField,Header("スタートボタン")] Button _startButton;

    [SerializeField,Header("シーン名")] string _sceneName;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
