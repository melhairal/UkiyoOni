using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orbCount : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private Text text;
    private int count = 0;
    void Start()
    {
        text = GetComponent<Text>();
    }

    
    void Update()
    {
        if (gameManager._useGravity)
        {
            count = gameManager.playerOrbCount;
            if (count >= 3)
            {
                text.color = new Color(1, 1, 0, 1);
                count = 3;
            }
            else
            {
                text.color = new Color(1, 1, 1, 1);
            }
            GetComponent<Text>().text = "Å~" + count + "                                    Å@ ";
        }
        else
        {
            count = gameManager.enemyOrbCount;
            if (count >= 3)
            {
                text.color = new Color(1, 1, 0, 1);
                count = 3;
            }
            else
            {
                text.color = new Color(1, 1, 1, 1);
            }
            GetComponent<Text>().text = "                                  Å@   Å~" + count;
        }
    }
}
