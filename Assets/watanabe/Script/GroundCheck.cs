using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ڒn����
/// </summary>
public class GroundCheck : MonoBehaviour
{
    public bool isGround = false;
    public Move _move;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            isGround = true;
            _move._jumpCount = 0;
            Debug.Log("���ɂ��܂�");
        }
    }
}
