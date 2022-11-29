using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    float rot = 0;
    void Start()
    {
        rot = transform.rotation.z * 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rot);
        transform.Rotate(0f, 0f, rot);
    }
}
