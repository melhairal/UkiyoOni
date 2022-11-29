using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Stone : MonoBehaviour
{
    public GameManager gameManeger;
    public GameObject target;

    private Vector3 origin;
    private Vector3 angle;

    private bool isStop = false;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        angle = transform.rotation.eulerAngles;
    }

    public void StoneFly(GameObject gameObject)
    {
        gameObject.transform.DOMove(target.transform.position, 1f).SetEase(Ease.Unset);
        gameObject.transform.DORotate(target.transform.rotation.eulerAngles, 1f, RotateMode.Fast).SetEase(Ease.Unset);
    }

    public void StoneFall(GameObject gameObject)
    {
        gameObject.transform.DOMove(origin, 1f).SetEase(Ease.Linear);
        gameObject.transform.DORotate(angle, 1f, RotateMode.Fast).SetEase(Ease.Unset);
    }
}
