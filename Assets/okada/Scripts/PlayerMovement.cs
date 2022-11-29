using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Header("スピード")] float _playerSpeed;

    [SerializeField, Header("ジャンプ力")] float _jumpForce;

    [SerializeField, Header("ジャンプの高さ")] float _jumpHeight;

    int _jumpCount = 2;

    Rigidbody2D _rb2D;

    float _vX = 0;

    bool _leftFlag = false;

    Animator _anim;

    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();

       
        _rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;

        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && _jumpCount < 2)
        {
            _rb2D.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);

            _anim.SetBool("jump", true);

            _jumpCount++;

        }
    }

    void FixedUpdate()
    {
        _vX = 0;
        if (_vX == 0)
        {
            _anim.SetBool("walk", false);
        }
        if (_rb2D.velocity.y == 0)
        {
            _anim.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.D)) // 右キーが押されたら
        {
            _anim.SetBool("walk", true);
            _vX = _playerSpeed; // 右に進む移動量を入れる
            _leftFlag = false;
        }
        if (Input.GetKey(KeyCode.A)) // 左キーが押されたら
        {
            _anim.SetBool("walk", true);
            _vX = -_playerSpeed; // 左に進む移動量を入れる
            _leftFlag = true;
        }

        _rb2D.velocity = new Vector2(_vX,_rb2D.velocity.y); // 移動処理

        this.GetComponent<SpriteRenderer>().flipX = _leftFlag; // 左右の向きを変える
    }

    void OnCollisionEnter2D(Collision2D other)
    { 
        _jumpCount = 0;
    }
}
