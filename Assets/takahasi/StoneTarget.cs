using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StoneTarget : MonoBehaviour
{
    [SerializeField]private GameManager gameManager;
    private GameObject target;
    private Vector2 origin;
    private Rigidbody2D rb;
    void Start()
    {
        target = transform.parent.gameObject;
        origin = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gameManager._useGravity)
        {
            FlyUp();
        }
        else
        {
            FlyDown();
        }
    }

    private bool flying = false;
    void FlyUp()
    {
        rb.gravityScale = 0;
        transform.DOMove(target.transform.position, 1f).SetEase(Ease.Linear);
    }

    void FlyDown()
    {
        //transform.DOMove(origin, 1f).SetEase(Ease.Linear);
        rb.gravityScale = 1;
    }
}
