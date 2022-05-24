﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3 (-3,0.5f,-3);
        }
        
    }

    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.name == "Plane")
        {
            transform.position = new Vector3(-3, 0.5f, -3);
        }
    }
}
