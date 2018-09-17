using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // example of bools
    public bool IsAWizard;

    // example of integers
    public int AmmoCount = 100;
    public int InventoryCount;

    // example of floats
    public float Health = 1.0f;
    public float Money;

    //example of strings
    public string PlayerName;
    public string Team = "Wolves";

    public Vector3 Location;

	// Use this for initialization
	void Start ()
    {
        print(PlayerName);
        print("has " + Money + " money");

        if (IsAWizard)
        {
            print(PlayerName + " Is a wizard");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (IsAWizard)
        {
            transform.position = Location;
        }
	}
}
