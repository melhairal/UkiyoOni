using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool _useGravity = true;
    private Stone[] flyObjects;
    public int playerOrbCount = 0;
    public int enemyOrbCount = 0;
    private bool onSkill = false;

    // Start is called before the first frame update
    void Start()
    {
        flyObjects = FindObjectsOfType<Stone>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && onSkill)
        {
            if(_useGravity)
            {
                _useGravity = false;
                foreach(var obj in flyObjects)
                {
                    obj.StoneFly(obj.gameObject);
                }
                
            }
            else if(!_useGravity)
            {
                _useGravity = true;
                foreach (var obj in flyObjects)
                {
                    obj.StoneFall(obj.gameObject);
                }
            }
            playerOrbCount = 0;
            onSkill = false;
        }

        
        if ( _useGravity )
        {
          //  Debug.Log("d—Íon");
        }
        else if(!_useGravity)
        {
            Debug.Log("d—Íoff");
        }
    }

    public void PlayerOrb()
    {
        if (_useGravity)
        {
            playerOrbCount++;
            Debug.Log(playerOrbCount);
            if (playerOrbCount >= 3)
            {
                onSkill = true;
            }
        }
    }

    public void EnemyOrb()
    {
        if (!_useGravity)
        {
            enemyOrbCount++;
            Debug.Log(enemyOrbCount);
            if (enemyOrbCount == 3)
            {
                enemyOrbCount = 0;
                _useGravity = true;
                foreach (var obj in flyObjects)
                {
                    obj.StoneFall(obj.gameObject);
                }
            }
        }
    }

}
