using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbUi : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private Vector2 playerCounter;
    private Vector2 enemyCounter;
    void Start()
    {
        playerCounter = transform.position;
        enemyCounter = new Vector2(14.2f, playerCounter.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager._useGravity)
        {
            transform.position = playerCounter;
        }
        else
        {
            transform.position = enemyCounter;
        }
    }
}
