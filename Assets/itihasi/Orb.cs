using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField, Header("クールタイム")] private float coolTime = 10f;
    [SerializeField, Header("取得判定")] private bool isHidden;
    public GameManager gameManeger;
    private Vector2 origin;
    void Start()
    {
        origin = transform.position;
    }
    void Update()
    {
        if(isHidden)
        {
            isHidden = false;
            StartCoroutine(RespawnOrb(coolTime));
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        isHidden = true;
        transform.position = new Vector2(-100, -100);
        if (other.CompareTag("Player"))
        {
            Debug.Log("hit p");
            gameManeger.PlayerOrb();
        }
        if (other.CompareTag("Chaser"))
        {
            Debug.Log("hit c");
            gameManeger.EnemyOrb();
        }
    }

    public IEnumerator RespawnOrb(float coolTime)
    {
        yield return new WaitForSeconds(coolTime);
        transform.position = origin;
    }
}
