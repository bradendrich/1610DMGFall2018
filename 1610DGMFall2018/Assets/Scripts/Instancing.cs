using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{
    public GameObject instance;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(instance, transform.position, transform.rotation);
        }
    }
}
