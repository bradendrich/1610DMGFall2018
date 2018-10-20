using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UponTrigger : MonoBehaviour
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
