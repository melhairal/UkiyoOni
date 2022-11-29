using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    float _fadeSpeed = 3f;
    float _alfa;
    [SerializeField] GameOver _gameOver;
    [SerializeField] Image _fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        _fadeImage = GetComponent<Image>();
        _alfa = _fadeImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameOver._isGameOver)
        {
            StartFadeOut();
        }
    }

    public void StartFadeOut()
    {
        _alfa += _fadeSpeed * Time.deltaTime;
        Debug.Log(_alfa);
    }
}
