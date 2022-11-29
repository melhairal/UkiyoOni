using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int time = 90;
    private int count = 0;
    void Start()
    {
        count = time;
        StartCoroutine(TimeCount());
    }


    void Update()
    {
        if(count == 0)
        {
            SceneManager.LoadScene("PlayerEndScene");
        }
    }

    private IEnumerator TimeCount()
    {
        for(int i = 0; i < time; i++)
        {
            count -= 1;
            GetComponent<Text>().text = count.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
