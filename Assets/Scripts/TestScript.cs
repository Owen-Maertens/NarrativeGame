using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //comment
        transform.position += new Vector3(1,0,0)*Time.deltaTime;
    }
}
