using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        Debug.Log(1);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")*10, Input.GetAxis("Vertical")*10, 0);
        transform.Translate(vec);
    }
}