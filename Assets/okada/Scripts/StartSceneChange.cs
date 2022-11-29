using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    [SerializeField,Header("�X�^�[�g�{�^��")] Button _startButton;

    [SerializeField,Header("�V�[����")] string _sceneName;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
