﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UponCollision : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
