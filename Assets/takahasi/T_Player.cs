using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Player : MonoBehaviour
{
    [SerializeField ,Header("���x")] private float speed = 10;
    [SerializeField, Header("�W�����v��")] private float jumpPower = 1;
    [SerializeField, Header("�ڒn����")] private GameObject onGround;
    private Rigidbody2D rb;
    private float jump = 0;
    private int jumpCount = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //�ڒn����
        bool ground = onGround.GetComponent<OnGround>().onGround;
        Debug.Log(ground);
        if (ground) jumpCount = 0;

        //���E�ړ�
        var h = Input.GetAxis("Horizontal");
        Vector2 force = new Vector2(h * speed, 0);
        rb.AddForce(force);

        //�W�����v
        if (Input.GetKeyDown(KeyCode.Q) && jumpCount < 1)
        {
            jumpCount++;
            jump = jumpPower;
        }

        if (jump > 0) jump -= 1;
        Vector2 jumpforce = new Vector2(0, jump);
        rb.AddForce(jumpforce);

        Debug.Log(jumpCount);
    }


}
