using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int n;
    void Start()
    {
        n = Random.Range(200, 251);
    }

    void Update()
    {
        int i = Time.frameCount-1;
        Debug.Log(gameObject.name + i);
        if (gameObject.tag == "Red" && i == 100)
        {
            rend.enabled = false;
        }
        if (gameObject.tag == "Blue" && i == n)
        {
            rend.enabled = false;
            
        }
    }
}
