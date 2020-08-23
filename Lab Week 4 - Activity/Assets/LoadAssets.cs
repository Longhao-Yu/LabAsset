using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    void Start()
    {
        redObj = Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
        blueObj = Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }
}
