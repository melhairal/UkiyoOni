using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private PlayerMovement _player;
    private Move _chaser;
    public bool _isGameOver = false;

    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        Debug.Log(_player.name);
        _chaser = GameObject.Find("Chaser").GetComponent<Move>();
        Debug.Log(_chaser.name);
    }

    /// <summary>
    /// ゲームオーバー処理、一回捕まったらゲームオーバー
    /// </summary>
    /// <param name="other"></param>
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            _isGameOver = true;
            _player.enabled = false;
            _chaser.enabled = false;
            SceneManager.LoadScene("ChaserEndScene");
        }
    }
}
