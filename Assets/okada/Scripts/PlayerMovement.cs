using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Header("�X�s�[�h")] float _playerSpeed;

    [SerializeField, Header("�W�����v��")] float _jumpForce;

    [SerializeField, Header("�W�����v�̍���")] float _jumpHeight;

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

        if (Input.GetKey(KeyCode.D)) // �E�L�[�������ꂽ��
        {
            _anim.SetBool("walk", true);
            _vX = _playerSpeed; // �E�ɐi�ވړ��ʂ�����
            _leftFlag = false;
        }
        if (Input.GetKey(KeyCode.A)) // ���L�[�������ꂽ��
        {
            _anim.SetBool("walk", true);
            _vX = -_playerSpeed; // ���ɐi�ވړ��ʂ�����
            _leftFlag = true;
        }

        _rb2D.velocity = new Vector2(_vX,_rb2D.velocity.y); // �ړ�����

        this.GetComponent<SpriteRenderer>().flipX = _leftFlag; // ���E�̌�����ς���
    }

    void OnCollisionEnter2D(Collision2D other)
    { 
        _jumpCount = 0;
    }
}
