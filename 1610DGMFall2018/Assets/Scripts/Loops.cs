using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public string[] Names;
    public GameObject[] Stuff;
	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < Names.Length; i++)
        {
            print(Names[i]);
        }

        foreach(GameObject stuff in Stuff)
        {
            print(stuff);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
