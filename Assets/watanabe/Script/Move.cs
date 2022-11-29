using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D _rb;
    [Tooltip("移動速度"), SerializeField] public float _moveSpeed = 5.0f;
    float _veloX;
    [Tooltip("ジャンプ力"), SerializeField] public float _jumpPower = 5.0f;
    [Tooltip("接地判定"), SerializeField] public bool isGround = false;
    public int _jumpCount = 0;
    public GroundCheck _ground;
    public Animator _anim;
    bool _leftFlag = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = _ground.isGround;
        Movement();
    }

    void FixedUpdate()
    {
        _veloX = 0;
        if (_veloX == 0)
        {
            _anim.SetBool("walk", false);
        }

        if (_rb.velocity.y == 0)
        {
            _anim.SetBool("jump", false);
        }
        //移動処理
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _anim.SetBool("walk", true);
            _veloX = _moveSpeed * -1;
            _leftFlag = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _anim.SetBool("walk", true);
            _veloX = _moveSpeed;
            _leftFlag = true;
        }

        _rb.velocity = new Vector2(_veloX, _rb.velocity.y);
        GetComponent<SpriteRenderer>().flipX = _leftFlag;
    }

    private void Movement()
    {
        //ジャンプ
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (_jumpCount < 2 && isGround == true)
            {
                isGround = false;
                _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
                _jumpCount++;
                Debug.Log("とんだ");
            }
            
            if (isGround == false)
            {
                _anim.SetBool("jump", true);
            }
        }
    }
}
