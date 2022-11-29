using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    public bool onGround = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onGround = true;
        Debug.Log("‚Í‚¢‚Á‚½");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
        Debug.Log("‚Å‚½");
    }
}
