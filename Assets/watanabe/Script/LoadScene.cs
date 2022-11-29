using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string _sceneName;
    public void OnCLickStartBuuton()
    {
            StartCoroutine("Change");
    }

    IEnumerator Change()
    { 
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(_sceneName);
    }
}
