﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNabe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0,0.07f,0);

        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(0,-0.07f,0);

        }

        
    }
}
