﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float x;
    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(0,x,0);     
    }
}
